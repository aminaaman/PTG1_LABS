using System;
using System.IO;

namespace FarManager
{
		class MainClass
		{
			static void ShowInfo(DirectoryInfo directory, int cursor)
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
				int cursor = 0;
				DirectoryInfo directory = new DirectoryInfo(@"/Users/Adela/Desktop");
				while (true)
				{
					Console.Clear();
					ShowInfo(directory, cursor);
					ConsoleKeyInfo pressedKey = Console.ReadKey();
					if (pressedKey.Key == ConsoleKey.UpArrow)
						if (cursor > 0)
							cursor--;
					if (pressedKey.Key == ConsoleKey.DownArrow)
						if (cursor < directory.GetFileSystemInfos().Length - 1)
							cursor++;
					if (pressedKey.Key == ConsoleKey.Enter)
					{
						FileSystemInfo fi = directory.GetFileSystemInfos()[cursor];
						if (fi.GetType() == typeof(DirectoryInfo))
							directory = new DirectoryInfo(fi.FullName);
						else
						{
							StreamReader sr = new StreamReader(fi.FullName);
							Console.Clear();
							Console.WriteLine(sr.ReadToEnd());
							sr.Close();
							Console.ReadKey();
						}

					}
				if (pressedKey.Key == ConsoleKey.Backspace)
					{
						try
						{
							directory = Directory.GetParent(directory.FullName);
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