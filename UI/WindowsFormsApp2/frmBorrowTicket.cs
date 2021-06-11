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

namespace WindowsFormsApp2
{
    public partial class frmBorrowTicket : Form
    {
        private string MemberName, MemberId;
        public frmBorrowTicket()
        {
            InitializeComponent();
            Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
                Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
        }

        public frmBorrowTicket(string MemId, string MemName)
        {
            InitializeComponent();
            this.MemberId = MemId;
            this.MemberName = MemName;     
        }

        DataTable dt = new DataTable();
        private void frmBorrowTicket_Load(object sender, EventArgs e)
        {
            txbBorrowMemberCardNumber.Text = MemberId;
            txblbBorrowMemberName.Text = MemberName;
            //Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
            //Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            //Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
            string query = "select * from BOOK where AVAILABLE = 1";

            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                dgvBorrowBook.DataSource = dt;
            }
        }

        private void btnCreateBorrowTicket_Click(object sender, EventArgs e)
        {
            if (txbBorrowMemberCardNumber.Text != "" && txbIdbook.Text!="")
            {
                frmBorrowedBooks f = new frmBorrowedBooks(txbBorrowMemberCardNumber.Text, txbIdbook.Text);
                f.ShowDialog();
                refr();
            }
            else
                MessageBox.Show("Fill card number !");
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("NAME LIKE '%{0}%'", txbSearch.Text);
            dgvBorrowBook.DataSource = dv;
        }

        private void dgvBorrowBook_SelectionChanged(object sender, EventArgs e)
        {
            int i;
            if (dgvBorrowBook.CurrentRow != null)
            {
                i = dgvBorrowBook.CurrentRow.Index;
                txbIdbook.Text = dgvBorrowBook.Rows[i].Cells[0].Value.ToString();
            }
        }

        public void refr()
        {
            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                string sql = "select * from BOOK where AVAILABLE = 1";
                MySqlDataAdapter SDA = new MySqlDataAdapter(sql, con);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "BOOK");
                dgvBorrowBook.DataSource = DS.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refr();
        }
    }
}
