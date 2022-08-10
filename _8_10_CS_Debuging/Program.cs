using System;

namespace _8_10_CS_Debuging
{
	internal class Program
	{
		enum ClassType
		{
			//직업 코드
			None = 0,
			Knight = 1,
			Archer = 2,
			Mage = 3
		}
		struct Player
		{
			//플레이어의 정보
			public int hp;
			public int attack;
		}
		enum MonsterType
		{
			None = 0,
			Slime = 1,
			Orc = 2,
			Skeleton = 3,
		}
		struct Monster
		{
			public int hp;
			public int attack;
		}
		static ClassType ChooseClass()
		{
			//직업선택 1은 전사, 2는 궁수, 3은 법사
			Console.WriteLine("직업을 선택하세요!");
			Console.WriteLine("[1] 기사");
			Console.WriteLine("[2] 궁수");
			Console.WriteLine("[3] 법사");

			ClassType choice = ClassType.None;
			string input = Console.ReadLine();
			switch (input)
			{
				case "1":
					choice = ClassType.Knight;
					break;
				case "2":
					choice = ClassType.Archer;
					break;
				case "3":
					choice = ClassType.Mage;
					break;
			}

			return choice;
		}
		static void CreatePlayer(in ClassType choice,out Player player)
		{
			//사용자의 입력에 따라 직업을 정하고 체력,공격력 할당
			switch (choice)
			{
				case ClassType.Knight:
					player.hp = 100;
					player.attack = 10;
					break;
				case ClassType.Archer:
					player.hp = 75;
					player.attack = 12;
					break;
				case ClassType.Mage:
					player.hp = 50;
					player.attack = 15;
					break;
				default:
					player.hp=0;
					player.attack=0;
					break;
			}
		}
		static void CreateRandomMonster(out Monster monster)
		{
			Random rand = new Random();
			int randMonster = rand.Next(1, 4);
			switch(randMonster)
			{
				case (int)MonsterType.Slime:
					Console.WriteLine("슬라임이 스폰되었습니다!");
					monster.hp=20;
					monster.attack=2;
					break;
				case (int)MonsterType.Orc:
					Console.WriteLine("오크가 스폰되었습니다!");
					monster.hp=40;
					monster.attack=4;
					break;
				case (int)MonsterType.Skeleton:
					Console.WriteLine("스켈레톤이 스폰되었습니다!");
					monster.hp=30;
					monster.attack=3;
					break;
				default:
					monster.hp=0;
					monster.attack=0;
					break;
			}
		}
		static void Fight(ref Player player,ref Monster monster)
		{
			while(true)
			{
				//플레이어가 몬스터 공격
				monster.hp -= player.attack;
				if(monster.hp <= 0)
				{
					Console.WriteLine("승리했습니다!");
					Console.WriteLine($"남은 체력 : {player.hp}");
					break;
				}
				//몬스터 반격
				player.hp-=monster.attack;
				if(player.hp <= 0)
				{
					Console.WriteLine("패배했습니다!");
					Console.WriteLine($"남은 체력 : {player.hp}");
					break;
				}
			}
		}
		static void EnterField(ref Player player)
		{
			while (true)
			{
				Console.WriteLine("필드에 들어왔습니다!");

				Monster monster;							//몬스터 
				CreateRandomMonster(out monster);			//랜덤으로 1~3 몬스터 중 하나를 리스폰
				
				Console.WriteLine("[1] 전투 개시!");
				Console.WriteLine("[2] 일정 확률로 마을로 도망");

				string input = Console.ReadLine();
				if(input =="1")
				{
					Fight(ref player,ref monster);
				}
				else if(input =="2")
				{
					// 33%
					Random rand = new Random();
					int randValue = rand.Next(0,101);
					if(randValue <= 33)
					{
						Console.WriteLine("도망치는데 성공했습니다");
						break;
					}
					else
					{
						Fight(ref player, ref monster);
					}
				}
			}
		}
		static void EnterGame(ref Player player)
		{
			Console.WriteLine("게임에 접속했습니다!");
			while(true)
			{
				Console.WriteLine("[1] 필드로 간다");
				Console.WriteLine("[2] 로비로 돌아가기");

				string input = Console.ReadLine();
				switch (input)
				{
					case "1":
						EnterField(ref player);
						break;
					case "2":
						return;
				}
			}
		}
		static void Main(string[] args)
		{
			while (true)
			{
				ClassType choice = ChooseClass();
				if (choice == ClassType.None)
					continue;

					//캐릭터 생성
					Player player;
					CreatePlayer(choice, out player);
					EnterGame(ref player);
				
			}
		}
	}
}
