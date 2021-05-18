<<<<<<< HEAD
﻿using MySql.Data.MySqlClient;
using System;
=======
﻿using System;
>>>>>>> c0b40bb500d8910a2dd6cd66370ec3b447f1a5c3
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using LibraryManagementClasses;
=======

>>>>>>> c0b40bb500d8910a2dd6cd66370ec3b447f1a5c3
namespace WindowsFormsApp2
{
               
    public partial class frmMainMenu : Form
    {
        
        
        
        public frmMainMenu()
        {
<<<<<<< HEAD
            InitializeComponent();
            Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
                Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);

        }
=======
            InitializeComponent();         
        }



>>>>>>> c0b40bb500d8910a2dd6cd66370ec3b447f1a5c3
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

<<<<<<< HEAD
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

=======
      
>>>>>>> c0b40bb500d8910a2dd6cd66370ec3b447f1a5c3
    }
}
