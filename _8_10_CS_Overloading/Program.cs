using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS_Overloading
{
	internal class Program
	{
		// 함수 이름의 재사용
		static int Add(int a, int b)
		{
			Console.WriteLine("Add int 호출");
			return a+b;
		}
		static int Add(int a, int b, int c)
		{
			Console.WriteLine("Add int 호출");
			return a+b+c;
		}
		static float Add(float a, float b)
		{
			Console.WriteLine("Add float 호출");
			return a+b;
		}
		static void Main(string[] args)
		{
			int ret = Program.Add(1, 2);
			Console.WriteLine(ret);

			float ret2 = Program.Add(2.0f, 3.0f);
			Console.WriteLine(ret2);
		}
	}
}
