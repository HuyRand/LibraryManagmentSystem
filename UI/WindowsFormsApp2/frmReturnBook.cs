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
    public partial class frmReturnTicket : Form
    {
        private string Member_Id, Member_Name;
        public frmReturnTicket()
        {
            InitializeComponent();
            Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
                Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
        }

        public frmReturnTicket(string M_id, string M_name)
        {
            InitializeComponent();
            this.Member_Id = M_id;
            this.Member_Name = M_name;
        }

        private void frmReturnTicket_Load(object sender, EventArgs e)
        {
            txbReturnMemberCardNumber.Text = Member_Id;
            txbReturnMemberName.Text = Member_Name;

            DataTable dt = new DataTable();
            //Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
            //Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            //Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
            string query = "select * from BOOK where AVAILABLE = 0";

            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                dgvReturnBook.DataSource = dt;
            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update BOOK set AVAILABLE = 1 where BOOKID = '" + txbId.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgvReturnBook.DataSource = dt;

                con.Close();
            }

            refr();
        }

        private void dgvReturnBook_SelectionChanged(object sender, EventArgs e)
        {
            int i;
            if (dgvReturnBook.CurrentRow != null)
            {
                i = dgvReturnBook.CurrentRow.Index;
                txbId.Text = dgvReturnBook.Rows[i].Cells[0].Value.ToString();
            }
        }

        public void refr()
        {
            using (MySqlConnection con = new MySqlConnection(Program.connectionString))
            {
                string sql = "select * from BOOK where AVAILABLE = 0";
                MySqlDataAdapter SDA = new MySqlDataAdapter(sql, con);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "BOOK");
                dgvReturnBook.DataSource = DS.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refr();
        }
    }
}
