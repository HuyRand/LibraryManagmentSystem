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
    public partial class fmrAttachImage : Form
    {
        string Book_Name, Author;
        bool Save_=false;
        public fmrAttachImage()
        {
            InitializeComponent();
        }
        public fmrAttachImage(string BookName, string Author)
        {
            this.Book_Name = BookName;
            this.Author = Author;
            InitializeComponent();
        }
        private void Browse_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox1.Image = File;
                this.Save_ = true;
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            //if SAVE_ == True -> procceed
            if (pictureBox1.Image != null) { 
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\{Book_Name}{Author}.jpg"))
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\{Book_Name}{Author}.jpg");
                pictureBox1.Image.Save(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\{Book_Name}{Author}.jpg");
            }
            this.Close();
            // OUT
        }



    }
}
