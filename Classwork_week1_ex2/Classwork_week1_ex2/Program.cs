using System;

namespace Classwork_week1_ex2
{
	class MainClass
	{
		static bool isEven(int a)
		{
			if (a % 2 == 0)
				return true;
			return false;
					
		}

		public static void Main(string[] args)
		{
			int n = args.Length;
			for (int i = 0; i < n; i++) 
			{
				string s = args[i]; // "1"
				int p = int.Parse(s); //p=5

				if (isEven(p) == false)
					Console.WriteLine(p);
				Console.ReadKey();
			}
		}
	}
}
