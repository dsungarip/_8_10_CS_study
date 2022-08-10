using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS_study
{
	internal class Program
	{
		//	out 키워드
		//	(읽기 불가능,쓰기 가능)
		//	매개변수가 out으로 전달되어도, 메서드에서 값을 읽지 못함.
		//	out으로 지정된 인자에 값을 무조건 할당해줘야함
		static void Divide(int a, int b, out int result1, out int result2)
		{
			result1 = a / b;		//result 값 할당
			result2 = a % b;
		}
		static void Main(string[] args)
		{
			int num1 = 10;
			int num2 = 3;

			int result1;			//초기화 생략가능
			int result2;

			Divide(10, 3, out result1, out result2);

			Console.WriteLine(result1);
			Console.WriteLine(result2);
		}
	}
}
