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
    public partial class MemberInfo : Form
    {
        public MemberInfo()
        {
            InitializeComponent();
        }

        private void LoadMember()
        {
            string connectionString = "Data Source=NEELWORKBG\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;";
            string query = @"
                SELECT m.MemberId, ms.MembershipId, m.Name, ms.Type
                FROM Member m
                LEFT JOIN MembershipType ms ON m.MembershipId = ms.MembershipId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvMember.DataSource = table;
            }
        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {
            LoadMember();
        }

        private void BackToHomeBtn2_Click(object sender, EventArgs e)
        {
            // Open LibraryForm
            LibraryForm libraryForm = new LibraryForm();
            libraryForm.ShowDialog();

            // Close the current MemberInfo form after LibraryForm is closed
            this.Close();
        }
    }
}
