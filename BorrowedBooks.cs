using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS
{
    public partial class BorrowedBooks : Form
    {
        public BorrowedBooks()
        {
            InitializeComponent();
        }

        private void LoadBorrowedRecords()
        {
            string connectionString = "Data Source=NEELWORKBG\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;";
            string query = @"
                SELECT br.Id, br.BookId, b.Title, br.MemberId, m.Name, br.BorrowDate, br.DueDate, br.ReturnDate, br.Fine
                FROM BorrowRecords br
                LEFT JOIN Books b ON br.BookId = b.BookId
                LEFT JOIN Member m ON br.MemberId = m.MemberId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvBorrow.DataSource = table;
            }
        }

        // Add this method to filter records with fines
        private void LoadBorrowedRecordsWithFine()
        {
            string connectionString = "Data Source=NEELWORKBG\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;";
            string query = @"
                SELECT br.Id, br.BookId, b.Title, br.MemberId, m.Name, br.BorrowDate, br.DueDate, br.ReturnDate, br.Fine
                FROM BorrowRecords br
                LEFT JOIN Books b ON br.BookId = b.BookId
                LEFT JOIN Member m ON br.MemberId = m.MemberId
                WHERE br.Fine > 0";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvBorrow.DataSource = table;
            }
        }

        private void BorrowedBooks_Load(object sender, EventArgs e)
        {
            LoadBorrowedRecords();
        }

        private void BackToHomeBtn1_Click(object sender, EventArgs e)
        {
            // Open LibraryForm
            LibraryForm libraryForm = new LibraryForm();
            libraryForm.ShowDialog();

            // Close the current BorrowedBooks form after LibraryForm is closed
            this.Close();
        }

        // Example event handler for a "Show Fines" button
        private void ShowFinesBtn_Click(object sender, EventArgs e)
        {
            LoadBorrowedRecordsWithFine();
        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
