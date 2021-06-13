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
using System.IO;
using System.Text.RegularExpressions;
namespace WindowsFormsApp2
{
               
    public partial class frmMainMenu : Form
    {
        
        public frmMainMenu()
        {
            InitializeComponent();
        }
        private void btnRegisterNewMember_Click(object sender, EventArgs e)
        {
            if (Program.connection.State == ConnectionState.Broken || Program.connection.State == ConnectionState.Closed) 
                Program.connection.Open();
            frmRegisterNewMember f = new frmRegisterNewMember();
            f.ShowDialog();
            btnSearchUser.PerformClick();
        }

        private void RegisterNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterNewMember f = new frmRegisterNewMember();
            f.ShowDialog();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (Program.connection.State == ConnectionState.Broken || Program.connection.State == ConnectionState.Closed)
                Program.connection.Open();
            frmAddNewBook f = new frmAddNewBook();
            f.ShowDialog();
            btnBookSearch.PerformClick();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewBook f = new frmAddNewBook();
            f.ShowDialog();
        }

        private void createBorrowTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txbIdentityNumber.Text != "")
            {
                frmBorrowTicket f = new frmBorrowTicket(txbIdentityNumber.Text, txbMemberName.Text);
                f.ShowDialog();
            }
        }

        private void createReturnTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txbIdentityNumber.Text != "")
            {
                frmReturnTicket f = new frmReturnTicket(txbIdentityNumber.Text, txbMemberName.Text);
                f.ShowDialog();
            }
        }

       

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.connection.State == ConnectionState.Open)
                Program.connection.Close();
            //Program.OpenMainMenuFormOnClose = false;
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

      
       

        private void borrowedBooksDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowedBooks f = new frmBorrowedBooks();
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMemberInfo.CurrentRow == null)
                return;
            string temp = txbIdentityNumber.Text;
            if (Program.connection.State == ConnectionState.Broken || Program.connection.State == ConnectionState.Closed)
                Program.connection.Open();
            string tempMemberEmail = Program.EmailChop(txbMemberEmail.Text);
            string tempMemberAddress = Program.Normalizer(txbMemberAddress.Text);
            string tempMemberPath = AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\{txbMemberName.Text}{tempMemberEmail}{tempMemberAddress}.jpg";
            if (File.Exists(tempMemberPath))
                File.Delete(tempMemberPath);
            string sql = $"DELETE FROM MEMBER WHERE MEMID = {txbIdentityNumber.Text};";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
            // check if the dude still has the books
            int [] Holder = new int[10];
            int size = 0;
            sql = $"SELECT BOOKID FROM BORROW WHERE MEMID = {temp}";
            MySqlCommand cmd2 = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                if (rdr2.GetString(0) != null) 
                {
                    Holder[size] = rdr2.GetInt32(0);
                    size++;
                }
            }
            rdr2.Close();
            for (int i = 0; i < size;  i++)
            {
                int Temp = Holder[i];
                sql = $"DELETE  FROM BOOK WHERE BOOKID = {Temp}";
                MySqlCommand cmd3 = new MySqlCommand(sql, Program.connection);
                MySqlDataReader rdr3 = cmd3.ExecuteReader();
                rdr3.Close();

                string sql2 = $"DELETE  FROM BORROW WHERE BOOKID = {Temp}";
                cmd3=new MySqlCommand(sql2, Program.connection);
                rdr3 = cmd3.ExecuteReader();
                rdr3.Close();
            }

            MessageBox.Show("deleted");
            txbMemberName.Text = "";
            txbMemberEmail.Text = "";
            txbMemberAddress.Text = "";
            txbIdentityNumber.Text = "";
            btnBookSearch.PerformClick();
            btnSearchUser.PerformClick();

        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBookInfo.CurrentRow == null)
                return;
            if (Program.connection.State == ConnectionState.Broken || Program.connection.State == ConnectionState.Closed)
                Program.connection.Open();
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Book_Images\\{txbBookName.Text}{txbAuthor.Text}.jpg"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Book_Images\\{txbBookName.Text}{txbAuthor.Text}.jpg");

            string sql = $"DELETE FROM BOOK WHERE BOOKID = {txbBookID.Text};";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();

            string sql2 = $"DELETE FROM LOCATION WHERE BOOKID = {txbBookID.Text};";
            MySqlCommand cmd2 = new MySqlCommand(sql2, Program.connection);
            MySqlDataReader rdr2 = cmd2.ExecuteReader();
            rdr2.Close();
            MessageBox.Show("deleted");
            txbBookName.Text = "";
            txbPublisher.Text = "";
            cbGenre.Text = "";
            txbBookPrice.Text = "";
            txbAuthor.Text = "";
            txbPublishYear.Text = "";
            txbBookID.Text = "";
            btnBookSearch.PerformClick();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (Program.connection.State == ConnectionState.Broken || Program.connection.State == ConnectionState.Closed)
                Program.connection.Open();
            string sql = $"UPDATE MEMBER\n" +
                $"SET\n" +
                $"NAME = '{txbMemberName.Text}',\n" +
                $"DOB = '{dtpDayOfBirth.Value.ToString("yyyy-MM-dd")}',\n" +
                $"EMAIL = '{txbMemberEmail.Text}',\n" +
                $"ADDRESS = '{txbMemberAddress.Text}'\n" +
                $"WHERE MEMID = {txbIdentityNumber.Text};";

            int i = new int();
            if (dgvMemberInfo.CurrentRow != null)
                i = dgvMemberInfo.CurrentRow.Index;
            else return;
            string tempOldName = dgvMemberInfo.Rows[i].Cells[1].Value.ToString();
            string tempOldEmail =Program.EmailChop(dgvMemberInfo.Rows[i].Cells[4].Value.ToString());
            string tempOldAddress = Program.Normalizer(dgvMemberInfo.Rows[i].Cells[5].Value.ToString());
            string oldImageFileName = AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\{tempOldName}{tempOldEmail}{tempOldAddress}.jpg";
            string newImageFileName = AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\" +
                $"{txbMemberName.Text}{Program.EmailChop(txbMemberEmail.Text)}{Program.Normalizer(txbMemberAddress.Text)}.jpg";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
            MessageBox.Show("updated");
            if (oldImageFileName != newImageFileName && File.Exists(oldImageFileName))
            {
                if (File.Exists(newImageFileName))
                {
                    File.Delete(newImageFileName);
                }
                File.Move(oldImageFileName, newImageFileName);
            }
            btnSearchUser.PerformClick();

        }

        private void btnChangeBookInfo_Click(object sender, EventArgs e)
        {
            if (Program.connection.State == ConnectionState.Broken || Program.connection.State == ConnectionState.Closed)
                Program.connection.Open();
            string sql = $"UPDATE BOOK\n" +
               $"SET\n" +
               $"NAME = '{txbBookName.Text}',\n" +
               $"PUBLISHER = '{txbPublisher.Text}',\n" +
               $"CATEGORY = '{cbGenre.Text}',\n" +
               $"PRICE = {txbBookPrice.Text},\n" +
               $"AUTHOR = '{txbAuthor.Text}',\n" +
               $"YEAR = {txbPublishYear.Text}\n" +
               $"WHERE BOOKID = {txbBookID.Text};";

            int i= new int ();
            if (dgvBookInfo.CurrentRow != null)
                i = dgvBookInfo.CurrentRow.Index;
            else return;
            string tempOldAuthor = dgvBookInfo.Rows[i].Cells[3].Value.ToString();
            string tempOldBookName= dgvBookInfo.Rows[i].Cells[1].Value.ToString();
            string oldImageFileName = AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Book_Images\\{tempOldBookName}{tempOldAuthor}.jpg";
            string newImageFileName = AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Book_Images\\{txbBookName.Text}{txbAuthor.Text}.jpg";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();

            MessageBox.Show("updated");
            btnBookSearch.PerformClick();
            if (oldImageFileName != newImageFileName && File.Exists(oldImageFileName)) {
                if (File.Exists(newImageFileName))
                {
                    File.Delete(newImageFileName);
                }
                File.Move(oldImageFileName, newImageFileName);
                //File.Copy(oldImageFileName, newImageFileName);
                //File.Delete(oldImageFileName);
            }

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

        private void btnUserInfoDetail_Click(object sender, EventArgs e)
        {
            int i;
            if (dgvMemberInfo.CurrentRow != null)
            {
                i = dgvMemberInfo.CurrentRow.Index;
                string txbMemberName = dgvMemberInfo.Rows[i].Cells[1].Value.ToString();
                string txbIdentityNumber = dgvMemberInfo.Rows[i].Cells[0].Value.ToString();
                string dtpDayOfBirth = dgvMemberInfo.Rows[i].Cells[2].Value.ToString();
                string txbMemberEmail = dgvMemberInfo.Rows[i].Cells[4].Value.ToString();
                string txbMemberAddress = dgvMemberInfo.Rows[i].Cells[5].Value.ToString();
                string cbMemberType = dgvMemberInfo.Rows[i].Cells[6].Value.ToString();
                frmMemberInfo f = new frmMemberInfo(txbMemberName, txbIdentityNumber, dtpDayOfBirth, txbMemberEmail, cbMemberType, txbMemberAddress, dtpRegistrationerDate.Text, txbMemberOwedMoney.Text);
                f.ShowDialog();
            }
 
        }

        private void btnBookInfoDetail_Click(object sender, EventArgs e)
        {
            int i;
            if (dgvBookInfo.CurrentRow != null)
            {
                i = dgvBookInfo.CurrentRow.Index;
                string Book_Name = dgvBookInfo.Rows[i].Cells[1].Value.ToString();
                string Book_ID = dgvBookInfo.Rows[i].Cells[0].Value.ToString();
                string Book_Genre = dgvBookInfo.Rows[i].Cells[4].Value.ToString();
                string Author = dgvBookInfo.Rows[i].Cells[3].Value.ToString();
                string Publisher = dgvBookInfo.Rows[i].Cells[2].Value.ToString();
                string PublishYear = dgvBookInfo.Rows[i].Cells[7].Value.ToString();
                string Book_Price = dgvBookInfo.Rows[i].Cells[6].Value.ToString();
                string Book_State = dgvBookInfo.Rows[i].Cells[5].Value.ToString();
                frmBookInfo f = new frmBookInfo(Book_Name, Book_ID, Book_Genre, Author, Book_State, Publisher, PublishYear, Book_Price);
                f.ShowDialog();
            }

        }
        public void refr()
        {
            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                string sql = "select * from BOOK";
                MySqlDataAdapter SDA = new MySqlDataAdapter(sql, con);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "BOOK");
                dgvBookInfo.DataSource = DS.Tables[0];
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refr();
        }

        private void loadStatistic(string temp1)
        {
            
            DataTable dt = new DataTable();
            string statDate = dtmThongKe.Value.ToString("MM");
            Console.WriteLine(statDate);
            string a = temp1;
            string s = $"SELECT " + a + $" FROM BORROW_LOG WHERE MONTH(RESERVE_DATE) = {statDate}  group by " + a + " ORDER BY COUNT(" + a + ")  DESC LIMIT 5 ;";
            string query = s;
            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                dgvStatistics.DataSource = dt;
            }
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            string temp;
            if (rdoTacGiaYeuThich.Checked)
                temp = "AUTHOR";
            else temp = "CATEGORY";
            loadStatistic(temp);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NumberOnlyInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void txbMemberAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9 @., \b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txbMemberName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9 \b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txbBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9 _\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
