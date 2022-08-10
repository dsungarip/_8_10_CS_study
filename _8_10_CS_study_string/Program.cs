using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_CS_study_string
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = "Herry Potter";

			//1. 찾기
			bool found = name.Contains("Herry");    //문자열 찾기(찾으면 true 못찾으면 false)
			int index = name.IndexOf('ㅋ');      //문자찾기(찾으면 문자열 번호 리턴, 못찾으면 -1리턴)

			//2. 변형
			name = name+" Junior";

			string lowerCaseName = name.ToLower();
			string UpperCaseName = name.ToUpper();
			string newName = name.Replace('r','l') ;

			//3. 분할
			string [] names = name.Split(new char[] { ' ' });
			string subStingName = name.Substring(5);
		}
	}
}