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
	}

}
