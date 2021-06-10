using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class frmMemberInfo : Form
    {
        private string nameMember, idMember, dateMember, mailMember, typeMember, addressMember, registerdayMember, ownMember;

        private void addImageBtton_Click(object sender, EventArgs e)
        {
            fmrAttachImage f = new fmrAttachImage(2, nameMember, mailMember, addressMember, null);
            f.ShowDialog();
            frmMemberInfo_Load(sender, e);
        }

        public frmMemberInfo()
        {
            InitializeComponent();
        }
        public frmMemberInfo(string name, string id, string date, string mail, string type, string address, string registerday, string own)
        {
            InitializeComponent();
            this.nameMember = name;
            this.idMember = id;
            this.dateMember = date;
            this.mailMember = mail;
            this.typeMember = type;
            this.addressMember = address;
            this.registerdayMember = registerday;
            this.ownMember = own;
        }

        private void frmMemberInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image!=null)
                pictureBox1.Image.Dispose();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateReturnTicket_Click(object sender, EventArgs e)
        {
            this.Close();
            frmReturnTicket f = new frmReturnTicket(idMember,nameMember);
            f.ShowDialog();
        }

        private void btnCreateBorrowTicket_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBorrowTicket f = new frmBorrowTicket(idMember,nameMember);
            f.ShowDialog();
        }

        private void frmMemberInfo_Load(object sender, EventArgs e)
        {
            txbMemberName.Text = nameMember;
            txbIdentityNumber.Text = idMember;
            txbDateOfBirth.Text = dateMember;
            txbMemberEmail.Text = mailMember;
            cbMemberType.Text = typeMember;
            txbMemberAddress.Text = addressMember;
            txbRegistrationDate.Text = registerdayMember;
            txbTotalOwedMoney.Text = ownMember;
            showPicture();
        }
        private void showPicture()
        {
            string tempEmail = EmailChop(mailMember);
            string tempAddress = Normalizer(addressMember);
            string temp = AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\{nameMember}{tempEmail}{tempAddress}.jpg";
            if (File.Exists(temp))
                pictureBox1.Image = Image.FromFile(temp);
            else pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\NotAvailable.jpg");
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
