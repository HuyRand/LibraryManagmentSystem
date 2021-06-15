using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementClasses
{
	public class Member
	{
		public int MEMID;
		public string NAME;
		public DateTime DOB;
		public int NUMBER_OF_BOOK_ALLOWED;
		public string EMAIL;
		public string ADDRESS;
		public string MEM_IMG_ID;
        private int v1;
        private string v2;
        private DateTime dateTime;
        private int v3;
        private string v4;
        private string v5;
        private int v6;
        private string v7;
        private string v8;

        public Member()
		{
			MEMID = 0;
			NAME = "unknown";
			DOB = DateTime.Today;
			NUMBER_OF_BOOK_ALLOWED = 0;
			EMAIL = "unknown";
			ADDRESS = "unknown";
			MEM_IMG_ID = "PATH";
		}

		public Member(int memid,string name,DateTime DoB, int Number_Of_Book_Allowed, string Email, string Address)
		{
			MEMID = memid;
			NAME = name;
			DOB = DoB;
			NUMBER_OF_BOOK_ALLOWED = Number_Of_Book_Allowed;
			EMAIL = Email;
			ADDRESS = Address;
			// path is AppDomain.CurrentDomain.BaseDirectory + "/Member_Images/" + EMAIL
			int index = Email.IndexOf("@");
			if (index > 0)
			MEM_IMG_ID = Email.Substring(0, index);
		}

        public Member(int v1, string v2, DateTime dateTime, int v3, string v4, string v5, int v6, string v7, string v8)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.dateTime = dateTime;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
            this.v8 = v8;
        }
    }

}
