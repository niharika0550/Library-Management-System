namespace LMS
{
    partial class LibraryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.cmbSubFilter = new System.Windows.Forms.ComboBox();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.GoToMemberButton = new System.Windows.Forms.Button();
            this.BookIdTxt = new System.Windows.Forms.TextBox();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.AuthorTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.GoToBorrowedBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GenreTxt = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // dgvBook
            // 
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(226, 347);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(550, 195);
            this.dgvBook.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(226, 153);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(95, 36);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "SEARCH";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(896, 602);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(96, 39);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(896, 657);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 39);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All",
            "Title",
            "Author",
            "Genre",
            "BookId"});
            this.cmbFilter.Location = new System.Drawing.Point(60, 216);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbFilter.TabIndex = 8;
            // 
            // cmbSubFilter
            // 
            this.cmbSubFilter.FormattingEnabled = true;
            this.cmbSubFilter.Location = new System.Drawing.Point(60, 255);
            this.cmbSubFilter.Name = "cmbSubFilter";
            this.cmbSubFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbSubFilter.TabIndex = 9;
            this.cmbSubFilter.Visible = false;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(60, 161);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(142, 22);
            this.SearchTxt.TabIndex = 2;
            // 
            // FilterBtn
            // 
            this.FilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBtn.Location = new System.Drawing.Point(226, 229);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(95, 38);
            this.FilterBtn.TabIndex = 10;
            this.FilterBtn.Text = "FILTER";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(360, 187);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(93, 53);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // GoToMemberButton
            // 
            this.GoToMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToMemberButton.Location = new System.Drawing.Point(527, 206);
            this.GoToMemberButton.Name = "GoToMemberButton";
            this.GoToMemberButton.Size = new System.Drawing.Size(231, 65);
            this.GoToMemberButton.TabIndex = 12;
            this.GoToMemberButton.Text = "GO TO MEMBER\'S DETAILS";
            this.GoToMemberButton.UseVisualStyleBackColor = true;
            this.GoToMemberButton.Click += new System.EventHandler(this.GoToMemberButton_Click);
            // 
            // BookIdTxt
            // 
            this.BookIdTxt.Location = new System.Drawing.Point(29, 674);
            this.BookIdTxt.Name = "BookIdTxt";
            this.BookIdTxt.Size = new System.Drawing.Size(125, 22);
            this.BookIdTxt.TabIndex = 13;
            // 
            // TitleTxt
            // 
            this.TitleTxt.Location = new System.Drawing.Point(218, 674);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(123, 22);
            this.TitleTxt.TabIndex = 14;
            // 
            // AuthorTxt
            // 
            this.AuthorTxt.Location = new System.Drawing.Point(398, 674);
            this.AuthorTxt.Name = "AuthorTxt";
            this.AuthorTxt.Size = new System.Drawing.Size(132, 22);
            this.AuthorTxt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "ENTER TITLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(398, 619);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "ENTER AUTHOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 619);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "ENTER PRICE";
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(584, 674);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(100, 22);
            this.PriceTxt.TabIndex = 20;
            // 
            // GoToBorrowedBtn
            // 
            this.GoToBorrowedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToBorrowedBtn.Location = new System.Drawing.Point(780, 206);
            this.GoToBorrowedBtn.Name = "GoToBorrowedBtn";
            this.GoToBorrowedBtn.Size = new System.Drawing.Size(231, 65);
            this.GoToBorrowedBtn.TabIndex = 21;
            this.GoToBorrowedBtn.Text = "GO TO BORROWED BOOKS";
            this.GoToBorrowedBtn.UseVisualStyleBackColor = true;
            this.GoToBorrowedBtn.Click += new System.EventHandler(this.GoToBorrowedBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "ENTER BOOKID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(733, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "ENTER GENRE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GenreTxt
            // 
            this.GenreTxt.Location = new System.Drawing.Point(737, 674);
            this.GenreTxt.Name = "GenreTxt";
            this.GenreTxt.Size = new System.Drawing.Size(100, 22);
            this.GenreTxt.TabIndex = 24;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(896, 719);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(100, 39);
            this.DeleteBtn.TabIndex = 25;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // LibraryForm
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1023, 801);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.GenreTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GoToBorrowedBtn);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AuthorTxt);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.BookIdTxt);
            this.Controls.Add(this.GoToMemberButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.cmbSubFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.label1);
            this.Name = "LibraryForm";
            this.Load += new System.EventHandler(this.LibraryForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button BorrowedButton;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ComboBox cmbSubFilter;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button GoToMemberButton;
        private System.Windows.Forms.TextBox BookIdTxt;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.TextBox AuthorTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Button GoToBorrowedBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GenreTxt;
        private System.Windows.Forms.Button DeleteBtn;
    }
}