using System;
using System.IO;  //library for using StreamReader and StreamWriter

namespace Prime_Min_inFile
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

		public static void dFile() //creat a function to find min and max in array
		{
			
			StreamReader sr = new StreamReader(@"/Users/Adela/Documents/a.txt"); //read from a.txt datas

			StreamWriter sw = new StreamWriter(@"/Users/Adela/Documents/result.txt");  //write or display a result in b.txt		
		    
			// "1 3 5 7 9 11" -> arr[0] = "1", arr[1] = "3"... 
			string[] arr = sr.ReadLine().Split();  

			/*
			string s = sr.ReadLine(); // "1 3 5 7 9 11"
            string[] arr = s.Split(); // arr[0] = "1", arr[1] = "3"...
			*/
			int min = 320000; //creat new, the biggest variable to find min

			foreach (string i in arr)       //convert array to string 
			{
				int a = int.Parse(i);      //convert string to integer

				//check if the number is prime and min 
				if (a < min && isPrime(a))
					min = a; //if it is the min number assign a value to min
			}
			//write a result in .txt file
			sw.WriteLine("The smallest prime number: " + min);

			//StreamReader and StreamWriter must be closed
			sw.Close();
			sr.Close();
		}
		static void Main(string[] args)
		{
			//call a function
			dFile();
			//window will not close until we will not press any key
			Console.ReadKey();
		}
	}
}