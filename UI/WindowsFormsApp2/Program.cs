using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp2
{
    static class Program
    {
        public static string server = "sql6.freesqldatabase.com";
        public static string database = "sql6405406";
        public static string uid = "sql6405406";
        public static string password = "N6lh1TIywW";
        public static string connectionString;
        public static MySql.Data.MySqlClient.MySqlConnection connection;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainMenu());
        }
    }
}
