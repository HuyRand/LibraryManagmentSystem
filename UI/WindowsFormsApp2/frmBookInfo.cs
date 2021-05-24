using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class frmBookInfo : Form
    {
        private string nameBook, idBook, genreBook, authorBook, stateBook, publisherBook, publishyearBook, priceBook;

        private void frmBookInfo_Load(object sender, EventArgs e)
        {
            txbBookName.Text = nameBook;
            txbBookID.Text = idBook;
            cbGenre.Text = genreBook;
            txbAuthor.Text = authorBook;
            cbState.Text = stateBook;
            txbPublisher.Text = publisherBook;
            txbPublishYear.Text = publishyearBook;
            txbPrice.Text = priceBook;

            if(txbBookID.Text == "121")
            {
                pcb1.Visible = true;
                pcb2.Visible = false;
                pcb3.Visible = false;
                pcb4.Visible = false;
                pcb5.Visible = false;
                pcb6.Visible = false;
                pcb7.Visible = false;
                pcb8.Visible = false;
            }

            if (txbBookID.Text == "122")
            {
                pcb2.Visible = true;
                pcb1.Visible = false;
                pcb3.Visible = false;
                pcb4.Visible = false;
                pcb5.Visible = false;
                pcb6.Visible = false;
                pcb7.Visible = false;
                pcb8.Visible = false;
            }

            if (txbBookID.Text == "123")
            {
                pcb3.Visible = true;
                pcb2.Visible = false;
                pcb1.Visible = false;
                pcb4.Visible = false;
                pcb5.Visible = false;
                pcb6.Visible = false;
                pcb7.Visible = false;
                pcb8.Visible = false;
            }

            if (txbBookID.Text == "124")
            {
                pcb4.Visible = true;
                pcb2.Visible = false;
                pcb3.Visible = false;
                pcb1.Visible = false;
                pcb5.Visible = false;
                pcb6.Visible = false;
                pcb7.Visible = false;
                pcb8.Visible = false;
            }

            if (txbBookID.Text == "125")
            {
                pcb5.Visible = true;
                pcb2.Visible = false;
                pcb3.Visible = false;
                pcb4.Visible = false;
                pcb1.Visible = false;
                pcb6.Visible = false;
                pcb7.Visible = false;
                pcb8.Visible = false;
            }

            if (txbBookID.Text == "117")
            {
                pcb6.Visible = true;
                pcb2.Visible = false;
                pcb3.Visible = false;
                pcb4.Visible = false;
                pcb1.Visible = false;
                pcb5.Visible = false;
                pcb7.Visible = false;
                pcb8.Visible = false;
            }

            if (txbBookID.Text == "126")
            {
                pcb7.Visible = true;
                pcb2.Visible = false;
                pcb3.Visible = false;
                pcb4.Visible = false;
                pcb5.Visible = false;
                pcb6.Visible = false;
                pcb1.Visible = false;
                pcb8.Visible = false;
            }

            if (txbBookID.Text == "127")
            {
                pcb8.Visible = true;
                pcb2.Visible = false;
                pcb3.Visible = false;
                pcb4.Visible = false;
                pcb5.Visible = false;
                pcb6.Visible = false;
                pcb7.Visible = false;
                pcb1.Visible = false;
            }
        }

           
        public frmBookInfo(string name, string id, string genre, string author, string state, string publisher, string publishyear, string price)
        {
            InitializeComponent();
            this.idBook = id;
            this.nameBook = name;
            this.genreBook = genre;
            this.authorBook = author;
            this.stateBook = state;
            this.publisherBook = publisher;
            this.publishyearBook = publishyear;
            this.priceBook = price;

            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (stateBook == "True")
                {
                    cmd.CommandText = "SELECT * FROM LOCATION WHERE BOOKID = '" + idBook + "';";
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    string s;
                    while (rdr.Read())
                    {
                        s = "Shelf: " + rdr.GetString(2) + ", Section: " + rdr.GetString(3) + ", Row number: " + rdr.GetString(4);
                        txbLocation.Text = s;
                    }
                    rdr.Close();
                }
                else if (stateBook=="False")
                {
                    cmd.CommandText = "SELECT ADDRESS FROM MEMBER,BORROW WHERE MEMBER.MEMID=BORROW.MEMID AND BORROW.BOOKID='" + idBook + "';";
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        txbLocation.Text = rdr.GetString(0);
                    }
                }
                con.Close();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmBookInfo()
        {
            InitializeComponent();
        }
    }
}
