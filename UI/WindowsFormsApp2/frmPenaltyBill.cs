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
    public partial class frmPenaltyBill : Form
    {
        private string idMember, nameMember, ownMember;
        public frmPenaltyBill()
        {
            InitializeComponent();
        }

        public frmPenaltyBill(string idMem, string nameMem, string ownMem)
        {
            InitializeComponent();
            this.idMember = idMem;
            this.nameMember = nameMem;
            this.ownMember = ownMem;
        }

        private void frmPenaltyBill_Load(object sender, EventArgs e)
        {
            txbMemberId.Text = idMember;
            txbMemberName.Text = nameMember;
            txbTotalOwedMoney.Text = ownMember;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
