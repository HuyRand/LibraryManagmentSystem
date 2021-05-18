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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmAddNewBook : Form
    {
        public frmAddNewBook()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
<<<<<<< HEAD

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string sql = "INSERT INTO `BOOK` (BOOKID, NAME, PUBLISHER, AUTHOR, CATEGORY, AVAILABLE, PRICE, YEAR, BOOK_IMG_ID) " +
              $"VALUES ('{txbNewBookID.Text}', '{txbNewBookName.Text}', '{txbNewBookPublisher.Text}', '{txbNewBookAuthor.Text}', " +
              $"'{cbNewBookGenre.Text}', '1', '{txbNewBookPrice.Text}', '{txbPublishYear.Text}', 'testing');";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
            MessageBox.Show("Added");
            Close();
        }
=======
>>>>>>> c0b40bb500d8910a2dd6cd66370ec3b447f1a5c3
    }
}
