using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementClasses
{
    public class Book
    {
        public int BOOKID;
        public string NAME;
        public string PUBLISHER;
        public string AUTHOR;
        public bool AVAILABLE;
        public string CATEGORY;
        public double PRICE;
        public int YEAR;
        public string BOOK_IMG_ID;
        public Book()
        {
            BOOKID = 0;
            NAME = "unknown";
            PUBLISHER = "unknown";
            AUTHOR = "unknow";
            AVAILABLE = false;
            CATEGORY = "unknown";
            PRICE = 0;
            YEAR = 0;
            BOOK_IMG_ID = "PATH";
        }

        public Book(int BookID,string Name, string Pub, string Author,  string Category, bool Status, double price, int Year,string image_id)
        {
            BOOKID = BookID;
            NAME = Name;
            PUBLISHER = Pub;
            AUTHOR = Author;
            AVAILABLE = Status;
            CATEGORY = Category;
            PRICE = price;
            YEAR = Year;
            // path is AppDomain.CurrentDomain.BaseDirectory + "/Book_Images/" + BOOK_IMG_ID;
            BOOK_IMG_ID = image_id;
        }
        public bool Eligible_To_Borrow(Member obj, string Table)
        {
            return true;
        }

    }
}
