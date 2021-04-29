using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ass = dateTimePicker1.Value;

            string sql = "INSERT INTO `MEMBER` (MEMID, NAME, DOB, NUMBER_OF_BOOK_ALLOWED, EMAIL, ADDRESS, MEM_IMG_ID) " +
              $"VALUES ('{textBox1.Text}', '{textBox2.Text}', '{dateTimePicker1.Value}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', '{textBox6.Text}');";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
            MessageBox.Show("Added");
        }
    }
}
