using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Snake
{
	class Program
	{
		//enum Direction { up, down, left, right };
		//Direction d = Direction.right;

		public int d = 0; //o-right; 1-left; 2-down; 3-up.

		static void Main(string[] args)
		{
			Snake snake = new Snake();
			Wall wall = new Wall();
			Food food = new Food();
			while (true)
			{
				Console.Clear();
				snake.Draw();
				wall.Draw();
				food.Draw();
				ConsoleKeyInfo pressed = Console.ReadKey();
				if (pressed.Key == ConsoleKey.UpArrow)
					snake.Move(0, -1);
				if (pressed.Key == ConsoleKey.DownArrow)
					snake.Move(0, 1);
				if (pressed.Key == ConsoleKey.LeftArrow)
					snake.Move(-1, 0);
				if (pressed.Key == ConsoleKey.RightArrow)
					snake.Move(1, 0);
				if (pressed.Key == ConsoleKey.Escape)
					break;
			
			}
		}
	}
}