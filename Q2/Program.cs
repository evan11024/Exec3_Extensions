using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string a = "asasasasaa";
			string b = a.Left(3);
		}

	}
	public static class Mystring
	{
		public static string Left(this string source , int length)
		{
			if (string.IsNullOrEmpty(source)) return string.Empty;
			if (length <= 0) return string.Empty;
			if (source.Length < length) return string.Empty;
			return source.Substring(0,length);
		}
	}
}
