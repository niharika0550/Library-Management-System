namespace LMS
{
    partial class MemberInfo
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
            this.BackToHomeBtn2 = new System.Windows.Forms.Button();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "MEMBER DETAILS";
            // 
            // BackToHomeBtn2
            // 
            this.BackToHomeBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHomeBtn2.Location = new System.Drawing.Point(570, 137);
            this.BackToHomeBtn2.Name = "BackToHomeBtn2";
            this.BackToHomeBtn2.Size = new System.Drawing.Size(177, 53);
            this.BackToHomeBtn2.TabIndex = 4;
            this.BackToHomeBtn2.Text = "Back To Home";
            this.BackToHomeBtn2.UseVisualStyleBackColor = true;
            this.BackToHomeBtn2.Click += new System.EventHandler(this.BackToHomeBtn2_Click);
            // 
            // dgvMember
            // 
            this.dgvMember.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(85, 236);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.Size = new System.Drawing.Size(610, 225);
            this.dgvMember.TabIndex = 5;
            // 
            // MemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(776, 488);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.BackToHomeBtn2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MemberInfo";
            this.Text = "MemberInfo";
            this.Load += new System.EventHandler(this.MemberInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackToHomeBtn2;
        private System.Windows.Forms.DataGridView dgvMember;
    }
}