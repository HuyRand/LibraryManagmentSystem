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
    }
}
