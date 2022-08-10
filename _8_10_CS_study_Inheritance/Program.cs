using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS__OOP
{
	//OOP(은닉성/상속성/다형성)

	class Player	//부모 클래스 or 기반 클래스
	{				//부모클래스에서 사용되는 변수, 함수들을 자식클래스도 사용할 수 있다.
		//필드
		static public int counter = 1; 
		public int id;
		public int hp;
		public int attack;
		public void Move()
		{
			Console.WriteLine("Player Move");
		}
		public void Attack()
		{
			Console.WriteLine("Player Attack");
		}

	}
	class Mage : Player
	{

	}
	class Archer : Player
	{

	}
	class Knight : Player	// 자식 클래스 or 파생 클래스
	{

	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Knight knight = new Knight();
			knight.Move();
		}
	}
}
