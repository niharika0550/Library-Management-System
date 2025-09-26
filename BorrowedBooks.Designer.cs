namespace LMS
{
    partial class BorrowedBooks
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
            this.label2 = new System.Windows.Forms.Label();
            this.BackToHomeBtn1 = new System.Windows.Forms.Button();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.ShowFinesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "BORROWED BOOKS DETAILS";
            // 
            // BackToHomeBtn1
            // 
            this.BackToHomeBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHomeBtn1.Location = new System.Drawing.Point(915, 102);
            this.BackToHomeBtn1.Name = "BackToHomeBtn1";
            this.BackToHomeBtn1.Size = new System.Drawing.Size(168, 62);
            this.BackToHomeBtn1.TabIndex = 3;
            this.BackToHomeBtn1.Text = "Back To Home";
            this.BackToHomeBtn1.UseVisualStyleBackColor = true;
            this.BackToHomeBtn1.Click += new System.EventHandler(this.BackToHomeBtn1_Click);
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(50, 311);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowHeadersWidth = 51;
            this.dgvBorrow.RowTemplate.Height = 24;
            this.dgvBorrow.Size = new System.Drawing.Size(1285, 199);
            this.dgvBorrow.TabIndex = 4;
            this.dgvBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellContentClick);
            // 
            // ShowFinesBtn
            // 
            this.ShowFinesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowFinesBtn.Location = new System.Drawing.Point(141, 184);
            this.ShowFinesBtn.Name = "ShowFinesBtn";
            this.ShowFinesBtn.Size = new System.Drawing.Size(141, 54);
            this.ShowFinesBtn.TabIndex = 5;
            this.ShowFinesBtn.Text = "SHOW FINES";
            this.ShowFinesBtn.UseVisualStyleBackColor = true;
            this.ShowFinesBtn.Click += new System.EventHandler(this.ShowFinesBtn_Click);
            // 
            // BorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1399, 673);
            this.Controls.Add(this.ShowFinesBtn);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.BackToHomeBtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BorrowedBooks";
            this.Text = "BorrowedBooks";
            this.Load += new System.EventHandler(this.BorrowedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackToHomeBtn1;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.Button ShowFinesBtn;
    }
}