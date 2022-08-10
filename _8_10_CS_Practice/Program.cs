using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS_Practice
{
	internal class Program
	{
		static int Factorial(int n)
		{
			for(int i = n-1; i>1; i--)
				n*=i;
			return n;
		}
		static void Main(string[] args)
		{
			int ret = Factorial(5);
			Console.WriteLine(ret);
		}
	}
}
