using System;
using System.Collections.Generic;

namespace Classwork_week3_ex1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Yellow;
			while (true)
			{
				ConsoleKeyInfo pressedKey = Console.ReadKey();
				if (pressedKey.Key == ConsoleKey.LeftArrow)
				{
					Console.WriteLine("Left");
				}
				if (pressedKey.Key == ConsoleKey.RightArrow)
				{
					Console.WriteLine("Right");
				}
				if (pressedKey.Key == ConsoleKey.UpArrow)
				{
					Console.WriteLine("Up");
				}
				if (pressedKey.Key == ConsoleKey.DownArrow)
				{
					Console.WriteLine("Down");
				}
				if (pressedKey.Key == ConsoleKey.Escape)
					break;
				if (pressedKey.Key == ConsoleKey.Enter)
					Console.Clear();
			}

		}
	}
}