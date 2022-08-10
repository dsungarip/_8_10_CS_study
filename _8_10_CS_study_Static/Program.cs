using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS__OOP
{
	class Knight
	{
		//	필드
		static public int counter=1;    //	오로지 1개만 존재한다.

		public int id;
		public int hp;
		public int attack;

		static public void test()
		{
			counter++;	//static을 붙인변수만 설정가능
		}

		static public Knight CreatKnight()
		{
			Knight knight = new Knight();
			knight.hp = 100;
			knight.attack = 1;
			return knight;
		}

		public Knight() //	new Knight(50) 괄호안에 값이 없다면 출력되는 생성자
		{
			id = counter;
			counter++;

			hp =100;
			attack = 10;
			Console.WriteLine("생성자 호출!");
		}
		public Knight Clone()
		{
			Knight knight2 = new Knight();
			knight2.hp= hp;
			knight2.attack=attack;
			return knight2;
		}
		public void Move()
		{
			Console.WriteLine("Knight Move");
		}
		public void Attack()
		{
			Console.WriteLine("Knight Attack");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Knight knight = Knight.CreatKnight();	//static
			knight.Move();  //일반

			Console.WriteLine();    //Console.WriteLine() == static 함수

			Random rand = new Random(); //Random rand = new Random() != static 함수 
			rand.Next();
		}
	}
}
