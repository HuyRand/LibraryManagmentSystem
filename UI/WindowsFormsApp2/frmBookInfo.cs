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
        }

        public frmBookInfo(string name, string id, string genre, string author, string state, string publisher, string publishyear, string price)
        {
            InitializeComponent();
            this.nameBook = name;
            this.idBook = id;
            this.genreBook = genre;
            this.authorBook = author;
            this.stateBook = state;
            this.publisherBook = publisher;
            this.publishyearBook = publishyear;
            this.priceBook = price;
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
