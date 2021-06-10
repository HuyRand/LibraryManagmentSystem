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
    public partial class fmrLogin : Form
    {
        string Server = "sql6.freesqldatabase.com";
        public fmrLogin()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Program.uid = Program.database = User_Name.Text;
            Program.password = Password.Text;
            if (User_Name.Text=="" || Password.Text =="")
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                Program.connectionString = "SERVER=" + Server + ";" + "DATABASE=" +
                    User_Name.Text + ";" + "UID=" + Program.uid + ";" + "PASSWORD=" + Password.Text + ";";
                Program.connection = new MySql.Data.MySqlClient.MySqlConnection(Program.connectionString);
                try
                {

                    Program.connection.Open();
                    if (Program.connection.State == ConnectionState.Open)
                    {
                        this.Hide();
                        frmMainMenu f = new frmMainMenu();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Database connection failed.");
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Wrong username or password");
                    MessageBox.Show(ex.ToString());
                    this.Show();
                }
            }
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }

        private void PassW_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Program.runApp = false;
            Close();
        }

        private void fmrLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
