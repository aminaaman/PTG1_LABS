using System;
using System.IO; //library for using StreamReader and StreamWriter

namespace MAX_MIN
{
	class Program
	{
		static void Ex1()
		{
			StreamReader sr = new StreamReader(@"/Users/Adela/Documents/a.txt"); //showing the path
			string[] arr = sr.ReadLine().Split(); // "1 3 5 7 9 11" -> arr[0] = "1", arr[1] = "3"...

			int min = 1000000; //giving large number to check min
			int max = 0; //giving small number to check min

			foreach (string i in arr)    //converting array to string 
			{
				int a = int.Parse(i); //converting string to integer


				//checks every number in array for minimum
				if (a < min)
				{
					min = a;
				}

				//checks every number in array for maximum
				if (a > max)
				{
					max = a;
				}


			}
			Console.WriteLine("minimum number is " + min);
			Console.WriteLine("maximum number is " + max);

			sr.Close();
		}
		static void Main(string[] args)
		{
			Ex1();
			Console.ReadKey();
		}
	}
}