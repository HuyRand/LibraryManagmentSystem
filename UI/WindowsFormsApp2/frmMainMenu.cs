using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
               
    public partial class frmMainMenu : Form
    {
        
        
        
        public frmMainMenu()
        {
            InitializeComponent();         
        }



        private void btnRegisterNewMember_Click(object sender, EventArgs e)
        {
            frmRegisterNewMember f = new frmRegisterNewMember();
            f.ShowDialog();
        }

        private void RegisterNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterNewMember f = new frmRegisterNewMember();
            f.ShowDialog();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            frmAddNewBook f = new frmAddNewBook();
            f.ShowDialog();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewBook f = new frmAddNewBook();
            f.ShowDialog();
        }

        private void createBorrowTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowTicket f = new frmBorrowTicket();
            f.ShowDialog();
        }

        private void createReturnTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnTicket f = new frmReturnTicket();
            f.ShowDialog();
        }

        private void receivePenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPenaltyBill f = new frmPenaltyBill();
            f.ShowDialog();
        }

      
    }
}
