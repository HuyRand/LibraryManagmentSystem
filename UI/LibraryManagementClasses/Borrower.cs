using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementClasses
{
    public class Borrower : Member
    {
        public DateTime RESERVE_DATE;
        public DateTime DUE_DATE;
        public DateTime RETURN_DATE;
        public int BOOKID;

        public Borrower(int MemID, int BookID,DateTime res, DateTime due, DateTime Ret)
        {
            this.MEMID = MemID;
            RESERVE_DATE = res;
            DUE_DATE = due;
            RETURN_DATE = Ret;
            BOOKID = BookID;
        }
    }
}
