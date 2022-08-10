using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS_study_class_TypeCasting
{
	// 다형성(polymorphism)
	class Player
	{
		protected int hp;
		protected int attack;
		public virtual void Move()
		{
			Console.WriteLine("Player 이동!");
		}
	}

	//오버로딩(함수 이름의 재사용), 오버라이딩(다형성을 이용)
	class Knight : Player
	{
		public override void Move()
		{
			base.Move();
			Console.WriteLine("Knight 이동!");
		}
	}
	class SuperKnight : Knight
	{
		public override void Move()
		{
			Console.WriteLine("SuperKnight 이동!");
		}
	}
	class Mage : Player
	{
		public int mp;
		public override void Move()
		{
			Console.WriteLine("Mage 이동!");
		}
	}
	internal class Program
	{
		static void EnterGame(Player player)
		{
			player.Move();

			Mage mage = (player as Mage);
			if (mage != null)   //null == '없음'
				mage.mp = 10;
		}

		static void Main(string[] args)
		{
			Knight knight = new Knight();
			Mage mage = new Mage();

			knight.Move();

			EnterGame(mage);

		}
	}
}
