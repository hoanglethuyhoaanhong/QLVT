using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLVT_APP.Constrains
{
	internal class TextEditConstrain : IET_Constrain
	{
		public bool CheckDC(string text)
		{
			if (text.Trim().Length == 0)
				return true;
			return false;
		}

		public bool CheckLength(string text, int max)
		{
			if (text.Trim().Length == 0 || text.Trim().Length > max) return true;
			return false;
		}

		public bool CheckName(string text)
		{
			String hoten = "[a-zA-Z]";
			if (!Regex.IsMatch(text.Trim(), hoten))
				return true;
			return false;
		}

		public bool CheckSDT(string text)
		{
			String PhoneNumber = "0\\d{9,10}";
			if (!Regex.IsMatch(text.Trim(), PhoneNumber))
				return true;
			return false;
		}
	}
}
