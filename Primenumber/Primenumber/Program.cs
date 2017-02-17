using System;

namespace Primenumber
{
	class Program
	{
		static bool isPrime(int a) //fuction to check if the number prime or not
		{
			for (int i = 2; i < a; i++)
			{
				if (a % i == 0)
					return false;
			}
			if (a == 1)
				return false;
			else
				return true; //if the number doesn't fit to conditions above, true is taken 
		}

		static void Main(string[] args)
		{
			
			string a = Console.ReadLine(); // input numbers
			string[] arr = a.Split(); // split numbers 


			//The set is given as input string into a variable string [] args
			int n = args.Length;

			for (int i = 0; i < n; i++)
			{
				string s = args[i]; // "5"
				int p = int.Parse(s); // p = 5

				//check it whether it is a prime number or not
				if (isPrime(p))
				{
					Console.WriteLine(p + " ");
				}
				Console.ReadKey();
			}
		}
	}
}