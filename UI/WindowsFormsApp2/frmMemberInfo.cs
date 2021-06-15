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
        private string nameMember, idMember, dateMember, mailMember, addressMember, registerdayMember, ownMember,classMember,majorMember;

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
        public frmMemberInfo(string name, string id, string date, string mail, string address, string registerday,string money,string class_,string major)
        {
            InitializeComponent();
            this.nameMember = name;
            this.idMember = id;
            this.dateMember = date;
            this.mailMember = mail;

            this.addressMember = address;
            this.registerdayMember = registerday;
            this.classMember = class_;
            this.majorMember = major;
            this.ownMember = money;
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
            txbMemberAddress.Text = addressMember;
            txbRegistrationDate.Text = registerdayMember;
            txbMemberMajor.Text = majorMember;
            txbMemberClass.Text = classMember;
            txbOwedMoney.Text = ownMember;
            showPicture();
        }
        private void showPicture()
        {
            string tempEmail = Program.EmailChop(mailMember);
            string tempAddress = Program.Normalizer(addressMember);
            string temp = AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\{nameMember}{tempEmail}{tempAddress}.jpg";
            if (File.Exists(temp))
                pictureBox1.Image = Image.FromFile(temp);
            else pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Member_Images\\NotAvailable.jpg");
        }

    }
}
