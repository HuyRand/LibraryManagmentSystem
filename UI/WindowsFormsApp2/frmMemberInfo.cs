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
        public frmMemberInfo()
        {
            InitializeComponent();
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
    }
}
