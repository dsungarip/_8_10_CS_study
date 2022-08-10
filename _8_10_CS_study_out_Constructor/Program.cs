using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS__OOP
{
	class Knight    
	{
		public int hp;
		public int attack;

		public Knight() // new Knight(50) 괄호안에 값이 없다면 출력되는 생성자
		{
			hp =100;
			attack = 10;
			Console.WriteLine("생성자 호출!");
		}

		public Knight(int hp) : this()  //new Knight(50) 괄호안에 값이 들어가면 출력되는 생성자
		{
			this.hp = hp;
			Console.WriteLine("int 생성자 호출");
		}

		public Knight(int hp, int attack) : this()  //new Knight(50) 괄호안에 값이 두개 들어가면 출력되는 생성자
		{
			this.hp = hp;
			this.attack = attack;
			Console.WriteLine("int, int 생성자 호출");
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
			Knight knight = new Knight(50,5);
		}
	}
}
