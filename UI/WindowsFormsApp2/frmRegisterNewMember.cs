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
    public partial class frmRegisterNewMember : Form
    {
        public frmRegisterNewMember()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string ass =dtpDateOfBirth.Value.Date.ToString("yyyy-MM-dd");
            DateTime dt = DateTime.ParseExact(ass, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dt.ToString("yyyy-MM-dd"));


            string sql = "INSERT INTO `MEMBER` (MEMID, NAME, DOB, NUMBER_OF_BOOK_ALLOWED, EMAIL, ADDRESS, MEM_IMG_ID) " +
              $"VALUES ('{txbNewMemberIDNumber.Text}', '{txbNewMemberName.Text}', '{dt.ToString("yyyy-MM-dd")}', '0'," +
              $" '{txbNewMemberEmail.Text}', '{txbNewMemberAddress.Text}', 'test');";
            MySqlCommand cmd = new MySqlCommand(sql, Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
            MessageBox.Show("Added");
            Close();
        }
    }
}
