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
using System.IO;

namespace WindowsFormsApp2
{
    public partial class frmAddNewBook : Form
    {
        int last_bookid_inserted;
        public frmAddNewBook()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string sql = "INSERT INTO `BOOK` (NAME, PUBLISHER, AUTHOR, CATEGORY, AVAILABLE, PRICE, YEAR, BOOK_IMG_ID) " +
              $"VALUES ('{txbNewBookName.Text}', '{txbNewBookPublisher.Text}', '{txbNewBookAuthor.Text}', " +
              $"'{cbNewBookGenre.Text}', '1', '{txbNewBookPrice.Text}', '{txbPublishYear.Text}', 'testing');";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();


            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT LAST_INSERT_ID()";
            command.Connection = Program.connection;
            IDataReader reader = command.ExecuteReader();
            if (reader != null && reader.Read())
               last_bookid_inserted = reader.GetInt32(0);
            reader.Close();


            //string sql3 = "SELECT LAST_INSERT_ID();";
            //MySqlCommand cmd3 = new MySqlCommand(sql3, Program.connection);
            //MySqlDataReader rdr3 = cmd3.ExecuteReader();
            //while (rdr3.Read())
            //{
            //    last_bookid_inserted = rdr3.GetInt32(0);
            //}
            //rdr3.Close();

            //Console.WriteLine(last_bookid_inserted.ToString());

            //MySqlCommand dbcmd = _conn.CreateCommand();
            //dbcmd.CommandText = sqlCommandString;
            //dbcmd.ExecuteNonQuery();


            string sql2 = "INSERT INTO `LOCATION` (BOOKID, ROW_NUMBER, SECTION_ID, SHELF_ID) " +
                $"VALUES ('{last_bookid_inserted}', '{txbNewBookRowNumber.Text}', "
                + $"'{txbNewBookSection_ID.Text}', '{txbNewBookShelf_ID.Text}');";
            MySqlCommand cmd2 = new MySqlCommand(sql2, Program.connection);
            MySqlDataReader rdr2 = cmd2.ExecuteReader();
            rdr2.Close();

            MessageBox.Show("Added");
            Close();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            if (txbNewBookName.Text == "" || txbNewBookAuthor.Text == "")
            {
                MessageBox.Show("Enter Name, Email, Address to add image");
                return;
            }
            fmrAttachImage f = new fmrAttachImage(1, txbNewBookName.Text, null,null,txbNewBookAuthor.Text);
            f.ShowDialog();
            frmAddNewBook_Load(sender, e);


        }

        private void frmAddNewBook_Load(object sender, EventArgs e)
        {
            if (txbNewBookName.Text != "" && txbNewBookAuthor.Text != "")
                showPicture();
        }
        private void showPicture()
        {
            string temp = AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Book_Images\\{txbNewBookName.Text}{txbNewBookAuthor.Text}.jpg";
            if (File.Exists(temp))
                pictureBox1.Image = Image.FromFile(temp);
            else pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Book_Images\\NotAvailable.jpg");
        }

        private void frmAddNewBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
        }
    }
}
