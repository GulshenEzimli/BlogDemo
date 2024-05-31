using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
	public static class StringFormatter
	{
		public static string GetLastWordOfString(string text, int length)
		{
			if (text.Length < length)
				return text.Substring(0,text.Length);

			return text.Substring(0, text.Substring(0, length).LastIndexOf(" "));
		}
	}
}
