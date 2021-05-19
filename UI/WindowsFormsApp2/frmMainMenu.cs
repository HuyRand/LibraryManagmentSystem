using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementClasses;
namespace WindowsFormsApp2
{
               
    public partial class frmMainMenu : Form
    {
        
        public frmMainMenu()
        {
            InitializeComponent();
            Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
                Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);

        }
        private void btnRegisterNewMember_Click(object sender, EventArgs e)
        {
            frmRegisterNewMember f = new frmRegisterNewMember();
            f.ShowDialog();
        }

        private void RegisterNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterNewMember f = new frmRegisterNewMember();
            f.ShowDialog();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            frmAddNewBook f = new frmAddNewBook();
            f.ShowDialog();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewBook f = new frmAddNewBook();
            f.ShowDialog();
        }

        private void createBorrowTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowTicket f = new frmBorrowTicket();
            f.ShowDialog();
        }

        private void createReturnTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnTicket f = new frmReturnTicket();
            f.ShowDialog();
        }

        private void receivePenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPenaltyBill f = new frmPenaltyBill();
            f.ShowDialog();
        }

        private void connectToTheDbServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Program.connection.Open();
                if (Program.connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Data entered succesfully.");
                    readBooksData();
                    readMembersData();
                    readBorrowersData();
                    readBooksLocationData();

                }
                else
                {
                    MessageBox.Show("Database connection failed.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.connection.State == ConnectionState.Open)
                Program.connection.Close();
        }
        public void readMembersData()
        {
            string sql = "SELECT * FROM `MEMBER` ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Program.MemberData.Add(new Member(Convert.ToInt32(rdr.GetValue(0)), rdr.GetString(1),rdr.GetDateTime(2), rdr.GetInt32(3), rdr.GetString(4), rdr.GetString(5)));
            }

            //testing if data dump is successful
            for (int i = 0; i < Program.MemberData.Count; i++)
            {
                Console.WriteLine(Program.MemberData[i].MEMID + " " + Program.MemberData[i].NAME +
                    " " + Program.MemberData[i].DOB.ToString() + " " + Program.MemberData[i].NUMBER_OF_BOOK_ALLOWED + " " +
                    Program.MemberData[i].EMAIL + " " + Program.MemberData[i].ADDRESS);
            }
            rdr.Close();

        }

        public void readBooksData()
        {
            string sql = "SELECT * FROM `BOOK` ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Program.BookData.Add(new Book(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetBoolean(5), rdr.GetInt32(6), rdr.GetInt32(7), rdr.GetString(8)));
            }
            rdr.Close();

        }

        public void readBooksLocationData()
        {
            string sql = "SELECT * FROM `LOCATION` ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
           
            while (rdr.Read())
            {
                Program.Book_LocationData.Add(new Location(rdr.GetString(0), rdr.GetInt32(1), rdr.GetInt32(2), rdr.GetInt32(3), rdr.GetInt32(4)));
            }
            rdr.Close();
        }

        public void readBorrowersData()
        {
            string sql = "SELECT * FROM `BORROW` ";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Program.BorrowerData.Add(new Borrower(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetDateTime(2), rdr.GetDateTime(3), rdr.GetDateTime(4)));
            }
            rdr.Close();

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
                Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
            string query = "select * from MEMBER";

            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                dgvMemberInfo.DataSource = dt;
            }

            DataTable dt1 = new DataTable();
            string query1 = "select * from BOOK";

            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query1, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt1.Load(reader);
                dgvBookInfo.DataSource = dt1;
            }
        }

        private void dgvMemberInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvMemberInfo.CurrentRow.Index;
            txbSearchWithCardnumber.Text = dgvMemberInfo.Rows[i].Cells[0].Value.ToString();
            txbSearchWithMemberName.Text = dgvMemberInfo.Rows[i].Cells[1].Value.ToString();
            txbMemberName.Text = dgvMemberInfo.Rows[i].Cells[1].Value.ToString();
            txbIdentityNumber.Text = dgvMemberInfo.Rows[i].Cells[3].Value.ToString();
            dtpDayOfBirth.Text = dgvMemberInfo.Rows[i].Cells[2].Value.ToString();
            txbMemberEmail.Text = dgvMemberInfo.Rows[i].Cells[4].Value.ToString();
            txbMemberAddress.Text = dgvMemberInfo.Rows[i].Cells[5].Value.ToString();
            cbMemberType.Text = dgvMemberInfo.Rows[i].Cells[6].Value.ToString();
            //txbMemberOwedMoney.Text = dgvMemberInfo.Rows[i].Cells[4].Value.ToString();
            //dtpRegiserDay.Text = dgvMemberInfo.Rows[i].Cells[4].Value.ToString();
        }

        private void dgvBookInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvBookInfo.CurrentRow.Index;
            txbSearchWithBookID.Text = dgvBookInfo.Rows[i].Cells[0].Value.ToString();
            txbSearchWithBookName.Text = dgvBookInfo.Rows[i].Cells[1].Value.ToString();
            cbSearchWithGenre.Text = dgvBookInfo.Rows[i].Cells[4].Value.ToString();
            txbSearchWithAuthor.Text = dgvBookInfo.Rows[i].Cells[3].Value.ToString();
            txbBookName.Text = dgvBookInfo.Rows[i].Cells[1].Value.ToString();
            txbBookID.Text = dgvBookInfo.Rows[i].Cells[0].Value.ToString();
            cbGenre.Text = dgvBookInfo.Rows[i].Cells[4].Value.ToString();
            txbAuthor.Text = dgvBookInfo.Rows[i].Cells[3].Value.ToString();
            txbPublisher.Text = dgvBookInfo.Rows[i].Cells[2].Value.ToString();
            //dtpAdmitDay.Text = dgvBookInfo.Rows[i].Cells[4].Value.ToString();
            txbPublishYear.Text = dgvBookInfo.Rows[i].Cells[7].Value.ToString();
            txbBookPrice.Text = dgvBookInfo.Rows[i].Cells[6].Value.ToString();
            cbBookState.Text = dgvBookInfo.Rows[i].Cells[5].Value.ToString();
        }
    }
}
