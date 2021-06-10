using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibraryManagementClasses;
using System.Text.RegularExpressions;
namespace WindowsFormsApp2
{
    static class Program
    {
        public static string server = "sql6.freesqldatabase.com";
        public static string database;
        public static string uid;
        public static string password;
        public static string connectionString;
        public static MySql.Data.MySqlClient.MySqlConnection connection;
        public static List<Book> BookData= new List<Book>();
        public static List<Member> MemberData=new List<Member>();
        public static List<Borrower> BorrowerData = new List<Borrower>();
        public static List<Location> Book_LocationData = new List<Location>();
        public const int MAXIMUM_NUMBER_OF_BOOK_CAN_BE_BORROWED = 10;
        //public static bool OpenMainMenuFormOnClose { get; set; }
        //public static bool runApp;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmrLogin());


            //OpenMainMenuFormOnClose = false;
            //runApp = true;
            //while (runApp)
            //{
            //    Application.Run(new fmrLogin());
            //    if (OpenMainMenuFormOnClose)
            //    {
            //        Application.Run(new frmMainMenu());
            //    }
            //}
        }
        public static string Normalizer(string s)
        {
            string temp = s;
            temp = Regex.Replace(temp, @"[.,,/,@]|[,]{2}", "_");
            return temp;
        }
        public static string EmailChop(string s)
        {
            if (s.Contains('@'))
            {
                string temp = s.Substring(0, s.IndexOf('@'));
                return temp;
            }
            if (s.Contains('.'))
            {
                string temp = s.Substring(0, s.IndexOf('.'));
                return temp;
            }
            return s;
        }
    }
}
