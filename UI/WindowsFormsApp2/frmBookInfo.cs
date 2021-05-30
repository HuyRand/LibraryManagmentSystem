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
using System.IO;

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

            // path is AppDomain.CurrentDomain.BaseDirectory + "/Book_Images/" + BOOK_IMG_ID;
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\{nameBook}{authorBook}.jpg"))
                pictureBox1.Image=Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\{nameBook}{authorBook}.jpg");
            else pictureBox1.Image= Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\NotAvailable.jpg");


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
