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
            //Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
            //    Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            //Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
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

        private void dgvMemberInfo_SelectionChanged(object sender, EventArgs e)
        {
            
            int i;
            if (dgvMemberInfo.CurrentRow != null )
            { i = dgvMemberInfo.CurrentRow.Index;
                txbMemberName.Text = dgvMemberInfo.Rows[i].Cells[1].Value.ToString();
                txbIdentityNumber.Text = dgvMemberInfo.Rows[i].Cells[0].Value.ToString();
                dtpDayOfBirth.Text = dgvMemberInfo.Rows[i].Cells[2].Value.ToString();
                txbMemberEmail.Text = dgvMemberInfo.Rows[i].Cells[4].Value.ToString();
                txbMemberAddress.Text = dgvMemberInfo.Rows[i].Cells[5].Value.ToString();
                cbMemberType.Text = dgvMemberInfo.Rows[i].Cells[6].Value.ToString();
                //txbMemberOwedMoney.Text = dgvMemberInfo.Rows[i].Cells[4].Value.ToString();
                //dtpRegiserDay.Text = dgvMemberInfo.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void dgvBookInfo_SelectionChanged(object sender, EventArgs e)
        {
            int i;
            if (dgvBookInfo.CurrentRow != null)
            {
                i = dgvBookInfo.CurrentRow.Index;
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
        private void LoaddgvMemberInfo()
        {
            DataTable dt = new DataTable();
            //Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
            //    Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            //Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
            string query = "select * from MEMBER";

            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                dgvMemberInfo.DataSource = dt;
            }
        }

        private void LoaddgvBookInfo()
        {
            DataTable dt = new DataTable();
            //Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
            //    Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            //Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
            string query = "select * from BOOK";

            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                dgvBookInfo.DataSource = dt;
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (DataGridViewRow row in dgvMemberInfo.Rows)
                {
                    try
                    {
                        dgvMemberInfo.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgvMemberInfo.Rows.Count > 0);

            string strCardNumber = txbSearchWithCardnumber.Text;
            string strName = txbSearchWithMemberName.Text;

            if (strName == "" && strCardNumber == "")
            {
                DataTable dt = new DataTable();
                //Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
                //    Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
                //Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
                string query = "select * from MEMBER";

                using (MySqlConnection con = new MySqlConnection(Program.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    dgvMemberInfo.DataSource = dt;
                }
            }
            else
            {
                string query = "SELECT * FROM `MEMBER` WHERE NAME  like '%" + strName + "%' AND MEMID like '" + strCardNumber + "%'";
                DataTable dt = new DataTable();
                //Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
                //    Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
                //Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);

                using (MySqlConnection con = new MySqlConnection(Program.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    dgvMemberInfo.DataSource = dt;
                }
            }
        }

        public void btnShowBookDetail_Click(object sender, EventArgs e)
        {
            frmBookInfo f = new frmBookInfo(txbBookName.Text, txbBookID.Text, cbGenre.Text, txbAuthor.Text, cbBookState.Text, txbPublisher.Text, txbPublishYear.Text, txbBookPrice.Text);
            f.ShowDialog();
        }

        private void btnShowMemberDetail_Click(object sender, EventArgs e)
        {
            frmMemberInfo f = new frmMemberInfo(txbMemberName.Text, txbIdentityNumber.Text, dtpDayOfBirth.Text, txbMemberEmail.Text, cbMemberType.Text, txbMemberAddress.Text, dtpRegiserDay.Text, txbMemberOwedMoney.Text);
            f.ShowDialog();
        }

        private void borrowedBooksDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowedBooks f = new frmBorrowedBooks();
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            string sql = $"DELETE FROM MEMBER WHERE 'MEMID' = {txbIdentityNumber.Text};";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            MessageBox.Show("deleted");
            rdr.Close();

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM BOOK WHERE 'BOOKID' = {txbBookID.Text};";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            MessageBox.Show("deleted");
            rdr.Close();

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            string sql = $"UPDATE MEMBER\n" +
                $"SET\n" +
                $"NAME = '{txbMemberName.Text}',\n" +
                $"DOB = '{dtpDayOfBirth.Value.ToString("yyyy-MM-dd")}',\n" +
                $"EMAIL = '{txbMemberEmail.Text}',\n" +
                $"ADDRESS = '{txbMemberAddress.Text}'\n" +
                $"WHERE MEMID = {txbIdentityNumber.Text};";

            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            MessageBox.Show("updated");
            rdr.Close();

        }

        private void btnChangeBookInfo_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE BOOK\n" +
               $"SET\n" +
               $"NAME = '{txbBookName.Text}',\n" +
               $"PUBLISHER = '{txbPublisher.Text}',\n" +
               $"CATEGORY = '{cbGenre.Text}',\n" +
               $"PRICE = {txbBookPrice.Text},\n" +
               $"YEAR = {txbPublishYear.Text}\n" +
               $"WHERE BOOKID = {txbBookID.Text};";

            MessageBox.Show(sql);
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            MessageBox.Show("updated");
            rdr.Close();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (DataGridViewRow row in dgvBookInfo.Rows)
                {
                    try
                    {
                        dgvBookInfo.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgvBookInfo.Rows.Count > 0);

            string strBookId = txbSearchWithBookID.Text;
            string strName = txbSearchWithBookName.Text;

            if (strName == "" && strBookId == "")
            {
                DataTable dt = new DataTable();
                //Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
                //    Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
                //Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
                string query = "select * from BOOK";

                using (MySqlConnection con = new MySqlConnection(Program.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    dgvBookInfo.DataSource = dt;
                }
            }
            else
            {
                string query = "SELECT * FROM `BOOK` WHERE NAME  like '%" + strName + "%' AND BOOKID like '" + strBookId + "%'";
                DataTable dt = new DataTable();
                //Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
                //    Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
                //Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);

                using (MySqlConnection con = new MySqlConnection(Program.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    dgvBookInfo.DataSource = dt;
                }
            }
        }
    }
}
