using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS_study_Hiding
{
	//	(은닉성)

	//	ex) 자동차
	//	핸들, 페달, 차문
			// 정기장치, 엔진, 기름<-> 외부 노출? 망가질 가능성 높음
	//	중요데이터들의 데이터 보존을 위함
	
	class Knight
	{
		//	접근 한정자
		//	public = 공개&상속공개, protected = 비공개&상속공개, private = 비공개&비상속
		protected int hp;	//접근한정자를 안적을 경우 private로 작동

	
	}
	class SuperKnight : Knight
	{
		void test()
		{
			hp = 10;
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Knight knight = new Knight();
			
		}
	}
}
