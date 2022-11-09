using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string a = "123";
			string aa = "asas";
			int b = a.ToInt(1);
			int c = aa.ToInt(1);
			Console.WriteLine(b);
			Console.WriteLine(c);
		}
	}
	public static class MyM
	{
		public static int ToInt(this string source, int defaultValue)
		{

			return int.TryParse(source, out int result) ? Convert.ToInt32(source) : defaultValue; 
		}
	}
}
