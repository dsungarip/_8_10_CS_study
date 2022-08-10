using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS_study_ref
{
	internal class Program
	{
		//	ref 키워드
		//	기존 변수를 메서드에서 수정하려 할때 사용한다.
		//	매개변수가 ref로 전달되기 전에 초기화를 시켜줘야 한다.
		//	ref == C언어 포인터의 역활과 동일하다
		static void AddOne(ref int number)
		{
			number++;					//	ref로 변수 'a'에 직접 값을 집어넣게 된다.
		}
		static void Main(string[] args)
		{
			int a = 0;					//	변수 초기화
			Program.AddOne(ref a);		//	함수 불러오기(ref 로 전달전 a를 초기화 함.)

			Console.WriteLine($"{a}");
		}
	}
}
