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

        DataTable dt = new DataTable();
        private void refresh_Click(object sender, EventArgs e)
        {
            if (txbMemid.Text != "" && txbBookid.Text!="")
            {
                using (MySqlConnection con = new MySqlConnection(Program.connectionString))
                {

                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update BOOK set AVAILABLE = 0 where BOOKID = '" + txbBookid.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                using (MySqlConnection con = new MySqlConnection(Program.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT NUMBER_OF_BOOK_ALLOWED FROM MEMBER WHERE MEMID = '" + txbMemid.Text + "';";
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr.GetInt16(0) <= Program.MAXIMUM_NUMBER_OF_BOOK_CAN_BE_BORROWED)
                        {
                            rdr.Close();
                            cmd.CommandText = "insert into BORROW values('" + txbMemid.Text + "', '" + txbBookid.Text + "', '" + dtpReserve.Text + "', '" + dtpDue.Text + "', '" + dtpReturn.Text + "')";
                            cmd.ExecuteNonQuery();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Maximum number of books borrowed exceeded");
                            return;
                        }
                    }

                    string s, Author, Category;
                    s = "SELECT AUTHOR, CATEGORY " + "\n" +
                        "FROM BOOK" + "\n" +
                        "WHERE BOOKID = '" + txbBookid.Text + "';";
                    cmd.CommandText = s;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Author = rdr.GetString(0);
                        Category = rdr.GetString(1);
                        rdr.Close();
                        cmd.CommandText = "insert into BORROW_LOG values(NOT NULL ,'" + txbMemid.Text + "', '" + txbBookid.Text + "', '" + dtpReserve.Text + "', '" + dtpDue.Text + "', '" + dtpReturn.Text + "', '" + Author + "', '" + Category + "')";
                        cmd.ExecuteNonQuery();
                        break;
                    }

                    s = "SELECT NUMBER_OF_BOOK_ALLOWED FROM MEMBER WHERE MEMID = '" + txbMemid.Text + "';";
                    cmd.CommandText = s;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        int temp = rdr.GetInt32(0) + 1;
                        rdr.Close();
                        cmd.CommandText = "UPDATE MEMBER SET NUMBER_OF_BOOK_ALLOWED = '" + temp + "' WHERE MEMID = '" + txbMemid.Text + "';";
                        cmd.ExecuteNonQuery();
                        break;
                    }
                    con.Close();
                }


                
                string query = "select * from BORROW where MEMID = '"+ txbMemid.Text +"'";

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
            if (txbMemid.Text != "")
            {
                DataTable dt = new DataTable();
                string query = "select * from BORROW where MEMID = '" + txbMemid.Text + "'";

                using (MySqlConnection con = new MySqlConnection(Program.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    //cmd.CommandText = "delete from BORROW where MEMID = 13";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    dgvBorrowedBooks.DataSource = dt;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                string query = "select * from BORROW";

                using (MySqlConnection con = new MySqlConnection(Program.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    //cmd.CommandText = "delete from BORROW where MEMID = 102";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    dgvBorrowedBooks.DataSource = dt;
                }
            }
        }
    }
}
