using System;
using System.IO; //library for using StreamReader and StreamWriter

namespace Recursion
{
	class Program
	{
		static void emptySpace(int level) //function that displays 2*spaces where you apply it 
		{
			for (int i = 0; i < level * 2; i++)
			{
				Console.WriteLine(" ");
			}
		}
		static void Ex2(string path, int level) //function that opens directories and files recursively
		{
			if (level > 2)
				return; // outputing only with 2 empty space
				/*
		     		 TRY identifies a block of code for which 
					 particular exceptions is activated
					 
					 CATCH catches an exception
					 for files or directories that are not avaible,
					 errors are invisible for users
				 */
			try
			{

				// Getting directories
				DirectoryInfo directory = new DirectoryInfo(path);
				DirectoryInfo[] directories = directory.GetDirectories();

				//Getting files
				FileInfo[] files = directory.GetFiles();
				Console.WriteLine("Files:" + directory.GetFiles().Length); //showing nmber of files in directories
				foreach (FileInfo file in files)
				{
					emptySpace(level); // getting names of files
					Console.WriteLine(file.Name);
				}

				Console.WriteLine("Directories:" + directories.Length); //showing number of d-s in d-s

				foreach (DirectoryInfo dInfo in directories)
				{
					//getting the fullname
					emptySpace(level);
					Console.WriteLine(dInfo.Name);
					Ex2(dInfo.FullName, level + 1); //applying func to open directories in directories

				}
			}

			catch (Exception e)
			{

			}
		}
		public static void Main(string[] args)
		{
			Ex2(@"/users/Adela/documents", 0);
			Console.ReadKey();
		}
	}
}