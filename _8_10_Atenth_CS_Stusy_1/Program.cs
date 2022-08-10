using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_Atenth_CS_Stusy_1
{
	class Monster
	{
		public string name;
		private int hp;
		private float def;
		
		public float DEF
		{
			get { return def; }
			set { def = value; }
		}
		public void test(string _name)
		{
			name = _name;
		}
		public void Move(){}
		public void Attack(){}

	}
	internal class Program
	{

		static void Main(string[] args)
		{
			Monster monster = new Monster();
			monster.name = "Goblin";
			monster.DEF = 20.3f;
			monster.Move();
			monster.Attack();
		}
	}
}
