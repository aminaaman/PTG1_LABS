using System;

namespace Prime_defence
{
	class MainClass
	{
		static bool isPrime(int a)
		{
			for (int i = 2; i < a; i++)
			{
				if (a % i == 0)
					return false;
			}
			if (a == 1)
				return false;
			else
				return true;
		}

		public static void Main(string[] args)
		{
			string a = Console.ReadLine();
			string[] arr = a.Split();

			for (int i = 0; i < arr.Length; i++)
			{
				string s = arr[i];
				int p = int.Parse(s);

				if (isPrime(p))
				{
					Console.WriteLine(p + " ");
				}
			

			}
			Console.ReadKey();
		}
	}
}
