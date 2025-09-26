using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LMS;

namespace LMS
{
    public partial class LibraryForm : Form
    {
        string connectionString = "Data Source=NEELWORKBG\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;";

        public LibraryForm()
        {
            InitializeComponent();
        }

        private void LibraryForm_Load_1(object sender, EventArgs e)
        {
            if (cmbFilter != null)
            {
                cmbFilter.Items.Clear();
                cmbFilter.Items.Add("Select"); // Add "Select" as the first option
                cmbFilter.Items.AddRange(new string[] { "BookId", "Title", "Author", "Genre", "Price" });
                cmbFilter.SelectedIndex = 0;
            }

            LoadSubFilterValues(); 

            cmbFilter.SelectedIndexChanged += OnFilterChanged;

            LoadBooks();
        }

        private void OnFilterChanged(object sender, EventArgs e)
        {
            LoadSubFilterValues();
            cmbSubFilter.Visible = true;
        }

        private void LoadSubFilterValues()
        {
            string selectedField = cmbFilter?.SelectedItem?.ToString();
            cmbSubFilter.Items.Clear();
            cmbSubFilter.Items.Add("Select");
         
            if (string.IsNullOrEmpty(selectedField) || selectedField == "Select")
                return;

            string query = "";
            switch (selectedField)
            {
                case "BookId":
                    query = "SELECT DISTINCT BookId FROM Books ORDER BY BookId";
                    break;
                case "Title":
                    query = "SELECT DISTINCT Title FROM Books ORDER BY Title";
                    break;
                case "Author":
                    query = "SELECT DISTINCT Author FROM Books ORDER BY Author";
                    break;
                case "Genre":
                    query = "SELECT DISTINCT GenreName FROM Genres ORDER BY GenreName";
                    break;
                case "Price":
                    query = "SELECT DISTINCT Price FROM Books ORDER BY Price";
                    break;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbSubFilter.Items.Add(reader[0].ToString());
                    }
                }
            }
            cmbSubFilter.SelectedIndex = 0;
        }

        private void LoadBooks(string keyword = "", string filter = "All")
        {
            string query = @"
                SELECT b.BookId, b.Title, b.Author, b.Price, g.GenreName
                FROM Books b
                LEFT JOIN Genres g ON b.GenreId = g.GenreId";

            if (!string.IsNullOrEmpty(keyword) && filter != "All")
            {
                switch (filter)
                {
                    case "Title":
                        query += " WHERE b.Title LIKE @keyword";
                        break;
                    case "Author":
                        query += " WHERE b.Author LIKE @keyword";
                        break;
                    case "BookId":
                        query += " WHERE b.BookId = @keyword";
                        break;
                    case "Genre":
                        // If keyword is numeric, treat as GenreId, else as GenreName
                        int genreId;
                        if (int.TryParse(keyword, out genreId))
                            query += " WHERE b.GenreId = @keyword";
                        else
                            query += " WHERE g.GenreName LIKE @keyword";
                        break;
                }
            }
            else if (!string.IsNullOrEmpty(keyword) && filter == "All")
            {
                query += @" WHERE 
                    b.Title LIKE @keyword OR 
                    b.Author LIKE @keyword OR 
                    g.GenreName LIKE @keyword OR 
                    CAST(b.BookId AS NVARCHAR) LIKE @keyword";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                if (!string.IsNullOrEmpty(keyword))
                {
                    if (filter == "BookId" || (filter == "Genre" && int.TryParse(keyword, out _)))
                        cmd.Parameters.AddWithValue("@keyword", keyword);
                    else
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                }

                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvBook.DataSource = table;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Read user text 
            string keyword = SearchTxt?.Text?.Trim() ?? "";

            // If empty, just reload all rows 
            if (string.IsNullOrEmpty(keyword))
            {
                LoadBooks(); // show all
                return;
            }

            LoadBooks(keyword, "All");
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            string filter = cmbFilter?.SelectedItem?.ToString() ?? "All";
            string keyword = cmbSubFilter.SelectedIndex > 0 ? cmbSubFilter.SelectedItem.ToString() : "";

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Select a value to filter.");
                return;
            }

            LoadBooks(keyword, filter);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LoadBooks(); // Show the whole table
            cmbSubFilter.SelectedIndex = 0; // Optionally reset genre selection to "Select"
            SearchTxt.Text = "";        // Optionally clear the search box
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string bookIdText = BookIdTxt?.Text?.Trim();
            string title = TitleTxt?.Text?.Trim();
            string author = AuthorTxt?.Text?.Trim();
            string priceText = PriceTxt?.Text?.Trim();
            string genreName = GenreTxt?.Text?.Trim();
            int bookId;
            decimal price;

            if (string.IsNullOrEmpty(bookIdText) || !int.TryParse(bookIdText, out bookId) ||
                string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) ||
                string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(genreName))
            {
                MessageBox.Show("Please enter all book details including a valid BookId and genre.");
                return;
            }
            if (!decimal.TryParse(priceText, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Get GenreId from genre name
            int genreId = -1;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT GenreId FROM Genres WHERE GenreName = @genreName", conn))
                {
                    cmd.Parameters.AddWithValue("@genreName", genreName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        genreId = Convert.ToInt32(result);
                    else
                    {
                        MessageBox.Show("Entered genre not found in database.");
                        return;
                    }
                }

                // Check for duplicate book before insert
                using (SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Books WHERE BookId = @bookId", conn))
                {
                    checkCmd.Parameters.AddWithValue("@bookId", bookId);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("This BookId already exists in the database.");
                        return;
                    }
                }

                // Insert book
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Books (BookId, Title, Author, Price, GenreId) VALUES (@bookId, @title, @author, @price, @genreId)", conn))
                {
                    cmd.Parameters.AddWithValue("@bookId", bookId);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@genreId", genreId);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Book added successfully!");
                        LoadBooks(); // Refresh table
                        // Optionally clear fields
                        BookIdTxt.Text = "";
                        TitleTxt.Text = "";
                        AuthorTxt.Text = "";
                        PriceTxt.Text = "";
                        GenreTxt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to add book.");
                    }
                }
            }
        }
        
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string bookIdText = BookIdTxt?.Text?.Trim();
            int bookId;

            if (string.IsNullOrEmpty(bookIdText) || !int.TryParse(bookIdText, out bookId))
            {
                MessageBox.Show("Please enter a valid BookId to update.");
                return;
            }

            // Check if book exists before updating
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Books WHERE BookId = @bookId", conn))
                {
                    checkCmd.Parameters.AddWithValue("@bookId", bookId);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists == 0)
                    {
                        try
                        {
                            throw new BookNotFoundException(bookId);
                        }
                        catch (BookNotFoundException ex)
                        {
                            MessageBox.Show(ex.Message, "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            string title = TitleTxt?.Text?.Trim();
            string author = AuthorTxt?.Text?.Trim();
            string priceText = PriceTxt?.Text?.Trim();
            string genreName = GenreTxt?.Text?.Trim();
            decimal price;
            int genreId = -1;

            var updates = new System.Collections.Generic.List<string>();
            var parameters = new System.Collections.Generic.List<SqlParameter>();

            if (!string.IsNullOrEmpty(title))
            {
                updates.Add("Title = @title");
                parameters.Add(new SqlParameter("@title", title));
            }
            if (!string.IsNullOrEmpty(author))
            {
                updates.Add("Author = @author");
                parameters.Add(new SqlParameter("@author", author));
            }
            if (!string.IsNullOrEmpty(priceText))
            {
                if (!decimal.TryParse(priceText, out price))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }
                updates.Add("Price = @price");
                parameters.Add(new SqlParameter("@price", price));
            }
            if (!string.IsNullOrEmpty(genreName))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT GenreId FROM Genres WHERE GenreName = @genreName", conn))
                    {
                        cmd.Parameters.AddWithValue("@genreName", genreName);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            genreId = Convert.ToInt32(result);
                        else
                        {
                            MessageBox.Show("Entered genre not found in database.");
                            return;
                        }
                    }
                }
                updates.Add("GenreId = @genreId");
                parameters.Add(new SqlParameter("@genreId", genreId));
            }

            if (updates.Count == 0)
            {
                MessageBox.Show("Please enter at least one field to update.");
                return;
            }

            string updateSql = $"UPDATE Books SET {string.Join(", ", updates)} WHERE BookId = @bookId";
            parameters.Add(new SqlParameter("@bookId", bookId));

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Book updated successfully!");
                        LoadBooks();
                        BookIdTxt.Text = "";
                        TitleTxt.Text = "";
                        AuthorTxt.Text = "";
                        PriceTxt.Text = "";
                        GenreTxt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No matching book found to update.");
                    }
                }
            }
        }

        private void GoToMemberButton_Click(object sender, EventArgs e)
        {
            // Open MemberInfo Form
            MemberInfo memberInfoForm = new MemberInfo();
            memberInfoForm.ShowDialog();

            // Close the library form after MemberInfo is closed
            this.Close();
        }

        private void GoToBorrowedBtn_Click(object sender, EventArgs e)
        {
            // Open BorrowedBooks Form
            BorrowedBooks borrowedBooksForm = new BorrowedBooks();
            borrowedBooksForm.ShowDialog();

            // Close the library form after BorrowedBooks is closed
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string bookIdText = BookIdTxt?.Text?.Trim();
            int bookId;

            if (string.IsNullOrEmpty(bookIdText) || !int.TryParse(bookIdText, out bookId))
            {
                MessageBox.Show("Please enter a valid BookId to delete.");
                return;
            }

            // Check if book exists before deleting
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Books WHERE BookId = @bookId", conn))
                {
                    checkCmd.Parameters.AddWithValue("@bookId", bookId);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists == 0)
                    {
                        try
                        {
                            throw new BookNotFoundException(bookId);
                        }
                        catch (BookNotFoundException ex)
                        {
                            MessageBox.Show(ex.Message, "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE BookId = @bookId", conn))
                {
                    cmd.Parameters.AddWithValue("@bookId", bookId);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Book deleted successfully!");
                        LoadBooks();
                        BookIdTxt.Text = "";
                        TitleTxt.Text = "";
                        AuthorTxt.Text = "";
                        PriceTxt.Text = "";
                        GenreTxt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No matching book found to delete.");
                    }
                }
            }
        }
    }
}

public class BookNotFoundException : Exception
{
    public BookNotFoundException(int bookId) 
        : base($"The book with ID {bookId} was not found.")
    {
    }
}