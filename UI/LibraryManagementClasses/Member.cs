using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementClasses
{
	public class Member
	{
		string NAME;
		DateTime DOB;
		int NUMBER_OF_BOOK_ALLOWED;
		string EMAIL;
		string ADDRESS;
		string MEM_IMG_ID;
		public Member()
		{
			NAME = "unknown";
			DOB = DateTime.Today;
			NUMBER_OF_BOOK_ALLOWED = 0;
			EMAIL = "unknown";
			ADDRESS = "unknown";
			MEM_IMG_ID = "PATH";
		}

		public Member(string name,DateTime DoB, int Number_Of_Book_Allowed, string Email, string Address)
		{
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
