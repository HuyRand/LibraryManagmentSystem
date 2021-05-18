using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Program.connectionString = "SERVER=" + Program.server + ";" + "DATABASE=" +
               Program.database + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Program.password + ";";
            Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
          

    }
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Program.connection.Open();
                if (Program.connection.State == ConnectionState.Open) 
                {
                    MessageBox.Show( "Data entered succesfully.");
                    string sql = "SELECT * FROM `MEMBER` ";
                    MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        MessageBox.Show(rdr[0] + " -- " + rdr[1]);
                    }
                    rdr.Close();
                }
                else
                {
                    MessageBox.Show( "Database connection failed.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( "Error occured. Please try again later.");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.connection.State == ConnectionState.Open)
                Program.connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 add_Member = new Form2();
            add_Member.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "ALTER TABLE 'MEMBER' " +
                "ALTER COLUMN 'DOB' DATE";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
        }
    }
}
