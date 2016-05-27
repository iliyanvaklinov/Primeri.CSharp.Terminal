using System;

namespace ReadFromComandLIne
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//дефиниране на променливи

			int a = 5, b = 0;

			//Въвежда не входни променливи

			Console.Write("а=5"+"\n");
			Console.Write("Моля въведете b: " );
			b=Convert.ToInt32(Console.ReadLine() ); 

			//Печат на резултат

			Console.WriteLine ("Резултата a + b = "+(a + b).ToString ()+"\n\n\n");

			string test = "1";
			test += ", 2";
			test += ", 99";
			test += ", 4";
			test += ", 5";
			Console.WriteLine ("Събиране с +=  : "+test+ "\n" );
			test=test.Replace (", ", ";");
			Console.WriteLine ("Работа с Replace  "+test+ "\n" );
			Console.WriteLine ("3 ти знак  "+test.Split (';') [2] );

		}
	}
}
