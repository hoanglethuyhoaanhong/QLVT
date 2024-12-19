using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT_APP.Constrains
{
	internal interface IET_Constrain
	{
		bool CheckLength(string text ,int max);
		bool CheckName(string text);
		bool CheckSDT(string text);
		bool CheckDC(string text);

	}
}
