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

            if(txbBookID.Text == "1")
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

            if (txbBookID.Text == "25")
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

            if (txbBookID.Text == "26")
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

            if (txbBookID.Text == "115")
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

            if (txbBookID.Text == "116")
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

            if (txbBookID.Text == "118")
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

            if (txbBookID.Text == "119")
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
