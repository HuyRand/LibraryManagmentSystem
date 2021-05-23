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
        private string idMember, idBook;
        public frmBorrowedBooks()
        {
            InitializeComponent();
            Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
               Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
        }

        public frmBorrowedBooks(string idM, string idB)
        {
            InitializeComponent();
            this.idMember = idM;
            this.idBook = idB;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (txbMemid.Text != "")
            {
                using (MySqlConnection con = new MySqlConnection(Program.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into BORROW values('" + txbMemid.Text + "', '" + txbBookid.Text + "', '" + dtpReserve.Text + "', '" + dtpDue.Text + "', '" + dtpReturn.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                DataTable dt = new DataTable();
                string query = "select * from BORROW";

                using (MySqlConnection con = new MySqlConnection(Program.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    //cmd.CommandText = "delete from BORROW where MEMID = 12";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    dgvBorrowedBooks.DataSource = dt;
                }

                txbMemid.Text = "";
                txbBookid.Text = "";
            }
        }

        private void frmBorrowedBooks_Load(object sender, EventArgs e)
        {
            txbMemid.Text = idMember;
            txbBookid.Text = idBook;

            DataTable dt = new DataTable();
            string query = "select * from BORROW";

            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                //cmd.CommandText = "delete from BORROW where MEMID = 0";
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                dgvBorrowedBooks.DataSource = dt;
            }
        }
    }
}
