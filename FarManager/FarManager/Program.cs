using System;
using System.IO;

namespace FarManager
{
		class MainClass
		{
			static void ShowInfo(DirectoryInfo directory, int cursor) //function to show folders and files with color(background and font color) 
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				int index = 0;
				foreach (FileSystemInfo fInfo in directory.GetFileSystemInfos())
				{
					if (index == cursor)
						Console.ForegroundColor = ConsoleColor.Red;
					else
						Console.ForegroundColor = ConsoleColor.Yellow;
					index++;
					if (fInfo.GetType() == typeof(FileInfo))
						Console.Write("File: ");
					else
						Console.Write("Directory: ");
					Console.WriteLine(fInfo.Name);


				}
			}

			static void Main(string[] args)
			{
				//initialize the datas 
				int cursor = 0; 
				DirectoryInfo directory = new DirectoryInfo(@"/Users/Adela/Desktop");
				while (true) //endless cycle
				{
					Console.Clear();  //to clear a window when another folder was opened
					ShowInfo(directory, cursor); //call function to display folders and files 
					ConsoleKeyInfo pressedKey = Console.ReadKey();
					if (pressedKey.Key == ConsoleKey.UpArrow)
						if (cursor > 0)
							cursor--;
					if (pressedKey.Key == ConsoleKey.DownArrow)
						if (cursor < directory.GetFileSystemInfos().Length - 1)
							cursor++;
					if (pressedKey.Key == ConsoleKey.Enter)
					{
						FileSystemInfo fi = directory.GetFileSystemInfos()[cursor]; //create a FileSystemInfo because we don't know type of the element 
						//if it is a folder, open folders in this folder
						if (fi.GetType() == typeof(DirectoryInfo))  //function GetType() is used to identify type of the element 
							directory = new DirectoryInfo(fi.FullName);
						else
						{
							//read from this file datas
							StreamReader sr = new StreamReader(fi.FullName);
							Console.Clear();  //to clear a window when another folder was opened
							Console.WriteLine(sr.ReadToEnd()); //display this datas on console 
							sr.Close();
							Console.ReadKey();
						}

					}
				if (pressedKey.Key == ConsoleKey.Backspace) 
					{
						try
						{
							directory = Directory.GetParent(directory.FullName);  //go back to the previous folder 
						}
						catch (Exception e)
						{

						}
					}
				if (pressedKey.Key == ConsoleKey.Escape)
						break;


				}


			}
		}
	}