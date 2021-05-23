﻿using MySql.Data.MySqlClient;
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
        public frmBorrowTicket()
        {
            InitializeComponent();
            Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
                Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
        }
        DataTable dt = new DataTable();
        private void frmBorrowTicket_Load(object sender, EventArgs e)
        { 
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
            if (txbBorrowMemberCardNumber.Text != "")
            {
                using (MySqlConnection con = new MySqlConnection(Program.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update BOOK set AVAILABLE = 0 where BOOKID = '" + txbIdbook.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvBorrowBook.DataSource = dt;

                    con.Close();
                }

                frmBorrowedBooks f = new frmBorrowedBooks(txbBorrowMemberCardNumber.Text, txbIdbook.Text);
                f.ShowDialog();
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
