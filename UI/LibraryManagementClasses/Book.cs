using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementClasses
{
    public class Book
    {
		string NAME;
		string PUBLISHER;
		string AUTHOR;
		bool AVAILABLE;
		string CATEGORY;
		double PRICE;
		int year;
		string BOOK_IMG_ID;
        public Book()
        {
            NAME = "unknown";
            PUBLISHER = "unknown";
            AUTHOR = "unknow";
            AVAILABLE = false;
            CATEGORY = "unknown";
            PRICE = 0;
            year = 0;
            BOOK_IMG_ID = "PATH";
        }

        public Book(string Name, string Pub, string Author, bool Status, string Category, double price, int year,string image_id)
        {
            NAME = Name;
            PUBLISHER = Pub;
            AUTHOR = Author;
            AVAILABLE = Status;
            CATEGORY = Category;
            PRICE = price;
            year = year;
            // path is AppDomain.CurrentDomain.BaseDirectory + "/Book_Images/" + BOOK_IMG_ID;
            BOOK_IMG_ID = image_id;
        }
        public bool Eligible_To_Borrow(Member obj, string Table)
        {
            return true;
        }

    }
}
