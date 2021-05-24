using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibraryManagementClasses;
namespace WindowsFormsApp2
{
    static class Program
    {
        public static string server = "sql6.freesqldatabase.com";
        public static string database = "sql6413004";
        public static string uid = "sql6413004";
        public static string password = "i93FYbMF3P";
        public static string connectionString;
        public static MySql.Data.MySqlClient.MySqlConnection connection;
        public static List<Book> BookData= new List<Book>();
        public static List<Member> MemberData=new List<Member>();
        public static List<Borrower> BorrowerData = new List<Borrower>();
        public static List<Location> Book_LocationData = new List<Location>();
        public const int MAXIMUM_NUMBER_OF_BOOK_CAN_BE_BORROWED = 10;

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
