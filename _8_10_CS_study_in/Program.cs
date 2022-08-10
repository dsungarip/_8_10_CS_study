using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS_study
{
	internal class Program
	{
		//	in 키워드
		//	(읽기 가능,쓰기 불가능)
		//	함수내부에서 수정불가, 
		//	초기화 생략이 불가능하고 in키워드를 생략 가능하다.
		static int Divide(in int a,in  int b)
		{
			return a+b;				//값을 반환해야 한다면 return을 써야함
		}
		static void Main(string[] args)
		{
			int num1 = 10;			//초기화 생략 불가능
			int num2 = 3;

			int result1 = Divide(num1, num2);            // in키워드 생략가능

			Console.WriteLine(result1);

		}
	}
}
