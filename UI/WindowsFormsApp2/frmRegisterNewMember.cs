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
using System.Text.RegularExpressions;


namespace WindowsFormsApp2
{
    public partial class frmRegisterNewMember : Form
    {
        public frmRegisterNewMember()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txbNewMemberName.Text=="")
            {
                MessageBox.Show("Member name can't be empty!");
                return;
            }
            string ass =dtpDateOfBirth.Value.Date.ToString("yyyy-MM-dd");
            DateTime dt = DateTime.ParseExact(ass, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dt.ToString("yyyy-MM-dd"));


            string sql = "INSERT INTO `MEMBER` (NAME, DOB, NUMBER_OF_BOOK_ALLOWED, EMAIL, ADDRESS, PENALTY,CLASS,MAJOR) " +
              $"VALUES ('{txbNewMemberName.Text}', '{dt.ToString("yyyy-MM-dd")}', '0'," +
              $" '{txbNewMemberEmail.Text}', '{txbNewMemberAddress.Text}', 0,'{txbNewMemberClass.Text}','{txbNewMemberMajor.Text}')";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
            MessageBox.Show("Added");
            Close();
        }

        private void addImageBttn_Click(object sender, EventArgs e)
        {
            if (txbNewMemberName.Text == "" || txbNewMemberAddress.Text == "" || txbNewMemberEmail.Text == "")
            {
                MessageBox.Show("Enter Name, Email, Address to add image");
                return;
            }
            fmrAttachImage f = new fmrAttachImage(2,txbNewMemberName.Text, txbNewMemberEmail.Text,txbNewMemberAddress.Text,null);
            f.ShowDialog();
            frmRegisterNewMember_Load(sender, e);
        }

        private void frmRegisterNewMember_Load(object sender, EventArgs e)
        {
            if (txbNewMemberEmail.Text!="" && txbNewMemberAddress.Text!="")
                showPicture();
        }
        private void showPicture()
        {
            string tempEmail = Program.EmailChop(txbNewMemberEmail.Text);
            string tempAddress = Program.Normalizer(txbNewMemberAddress.Text);
            string temp = AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\{txbNewMemberName.Text}{tempEmail}{tempAddress}.jpg";
            if (File.Exists(temp))
                pictureBox1.Image = Image.FromFile(temp);
            else pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\NotAvailable.jpg");
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmRegisterNewMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
        }

        private void txbNewMemberEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9 @., \b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txbNewMemberName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9 \b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
