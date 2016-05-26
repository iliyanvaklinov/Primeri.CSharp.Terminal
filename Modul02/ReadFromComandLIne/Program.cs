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
			//Пе1ат на резултат
			Console.WriteLine ("Резултата a + b = "+(a + b).ToString ()+"\n\n\n");
		}
	}
}
