using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS__OOP
{
	//	객체(OOP  Object Oriented Programming)

	//	Knight
	//	속성 : hp, attack, pos(좌표) 등등
	//	기능 : Move , Attack, Die

	class Knight	//Ref 참조
	{
		public int hp;
		public int attack;

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

	struct Mage		//복사
	{
		public int hp;
		public int attack;
	}
	internal class Program
	{
		static void KillMage(Mage mage)
		{
			mage.hp=0;
		}
		static void KillKnight(Knight knight)
		{
			knight.hp=0;
		}

		static void Main(string[] args)
		{
			Mage mage;
			mage.hp = 100;
			mage.attack = 50;
			KillMage(mage);

			Mage mage2 = mage;
			mage2.hp = 0;

			Knight knight = new Knight();
			knight.hp = 100;
			knight.attack = 10;
			KillKnight(knight);

			Knight knight2 = knight.Clone();
		}
	}
}
