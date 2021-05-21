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
    public partial class frmMemberInfo : Form
    {
        private string nameMember, idMember, dateMember, mailMember, typeMember, addressMember, registerdayMember, ownMember;

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

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateReturnTicket_Click(object sender, EventArgs e)
        {
            this.Close();
            frmReturnTicket f = new frmReturnTicket();
            f.ShowDialog();
        }

        private void btnCreateBorrowTicket_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBorrowTicket f = new frmBorrowTicket();
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
        }
    }
}
