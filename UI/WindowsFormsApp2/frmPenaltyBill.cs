using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp2
{
    public partial class frmPenaltyBill : Form
    {
        int owedMoney, paid, penalty;
        string memName,memID;
        public frmPenaltyBill()
        {
            InitializeComponent();

        }
        public frmPenaltyBill(string id,string name, int memPenalty) {
            InitializeComponent();
            this.memID = id;
            this.memName = name;
            this.owedMoney = memPenalty;
        }

        private void txbPenalty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void frmPenaltyBill_Load(object sender, EventArgs e)
        {
            txbTotalOwedMoney.Text = Convert.ToString(owedMoney);
            txbMemberName.Text = memName;
            penalty = paid = 0;

        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            if (txbPaid.Text != "" && txbPenalty.Text != "")
            {
                paid = Convert.ToInt32(txbPaid.Text);
                penalty = Convert.ToInt32(txbPenalty.Text);
            }
            else { 
                MessageBox.Show("Penalty and Paid can't be empty, base value should be 0!");
                penalty = paid = 0;
                txbPaid.Text = "0";
                txbPenalty.Text = "0";
                return;
            }
            if (owedMoney >= paid)
            {
                owedMoney = owedMoney - paid + penalty;
                txbTotalOwedMoney.Text = Convert.ToString(owedMoney);
                penalty = paid = 0;
                if (Program.connection.State == ConnectionState.Broken || Program.connection.State == ConnectionState.Closed)
                    Program.connection.Open();
                string sql = $"UPDATE MEMBER\n" +
                             $"SET\n"+
                             $"PENALTY = {txbTotalOwedMoney.Text}\n" +
                             $"WHERE MEMID = {memID};";
                MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
            } else
            {
                MessageBox.Show("Can't over pay the total amount of money owed");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
