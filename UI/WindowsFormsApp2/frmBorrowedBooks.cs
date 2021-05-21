using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmBorrowedBooks : Form
    {
        public frmBorrowedBooks()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBorrowedBooks_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
                Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
            string query = "select * from BORROW";

            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                dgvBorrowedBooks.DataSource = dt;
            }
        }
    }
}
