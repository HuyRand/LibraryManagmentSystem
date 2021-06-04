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
using System.Text.RegularExpressions;
namespace WindowsFormsApp2
{
    public partial class fmrAttachImage : Form
    {
        string SaveName, Author, Email, Address;
        int saveType = 0;
        bool Save_=false;
        public fmrAttachImage()
        {
            InitializeComponent();
        }
        public fmrAttachImage(int type, string Name, string Email, string Address, string Author)
        {
            this.saveType = type;
            this.SaveName = Name;
            if (type == 2 && Email !="" && Address!="") { 
            this.Email = EmailChop(Email);
            this.Address = Normalizer(Address);
            }
            else
            {
                this.Email = Email;
                this.Address = Address;
            }
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
            switch (saveType)
            {
                //save book image
                case 1:
                    if (pictureBox1.Image != null)
                    {
                        if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Book_Images\\{SaveName}{Author}.jpg"))
                            File.Delete(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Book_Images\\{SaveName}{Author}.jpg");
                        pictureBox1.Image.Save(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Book_Images\\{SaveName}{Author}.jpg");
                    }
                    break;
                //save member iamge
                case 2:
                    if (pictureBox1.Image != null)
                    {
                        if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\{SaveName}{Email}{Address}.jpg"))
                            File.Delete(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\{SaveName}{Email}{Address}.jpg");
                        pictureBox1.Image.Save(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\{SaveName}{Email}{Address}.jpg");
                    }
                    break;
                default:
                    break;
            }
            this.Close();
            // OUT
        }
        public string Normalizer(string s)
        {
            string temp = s;
            temp = Regex.Replace(temp, @"[.,,/,@]|[,]{2}", "_");
            return temp;
        }
        public string EmailChop(string s)
        {
            string temp = s.Substring(0, s.IndexOf('@'));
            return temp;
        }
    }
}
