using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementClasses
{
    public class Location : Book
    {
        public string LOCA_ID;
        public int SHELF_ID;
        public int SECTION_ID;
        public int ROW_NUMBER;

        public Location(string LoID, int BookID, int ShelfID, int SectionID, int RowNumber)
        {
            this.BOOKID = BOOKID;
            LOCA_ID = LoID;
            SHELF_ID = ShelfID;
            ROW_NUMBER = RowNumber;
        }
    }
}
