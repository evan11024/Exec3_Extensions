using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool result = MyMath.IsEven(100);
			bool result2 = 11.IsOdd();
			Console.WriteLine(result);
			Console.WriteLine(result2);
		}
	}
	public static class MyMath
	{
		public static bool IsOdd(this int source)
		{
			return source%2 == 1;
		}
		public static bool IsEven(this int source)
		{
			return source%2 == 0;
		}
	}
}
