using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS_study_class_TypeCasting
{
	// 클래스 형식변환
	class Player
	{
		protected int hp;
		protected int attack;
	}
	class Knight : Player
	{

	}
	class Mage : Player
	{
		public int mp;
	}
	internal class Program
	{
		static void EnterGame(Player player)
		{
			Mage mage = (player as Mage);
			if (mage != null)	//null == '없음'
			{
				mage.mp = 10;
			}
		}
		
		static void Main(string[] args)
		{
			Knight knight = new Knight();
			Mage mage = new Mage();

			EnterGame(mage);

		}
	}
}
