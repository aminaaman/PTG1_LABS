﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;


namespace Complex
{
	public class Program
	{
		[Serializable]
		public class Complex
		{
			public int x;
			public int y;
			public Complex(int x, int y) //constructor that initializes info
			{
				this.x = x;
				this.y = y;
			}

			static int gcd(int x, int y) //function that calculates gcd of two complex numbers
			{
				if (x == 0)
					return y;
				return gcd(y % x, x);
			}

			public override string ToString() //function that outputs data as a string
			{
				return this.x / gcd(this.x, this.y) + "/" + this.y / gcd(this.x, this.y);
			}

			public static Complex operator +(Complex x, Complex y) //function for overloading +
			{
				Complex c = new Complex(x.x * y.y + y.x * x.y, x.y * y.y);
				return c;
			}
			public static Complex operator -(Complex x, Complex y) //function for overloading -
			{
				Complex c = new Complex(x.x * y.y - y.x * x.y, x.y * y.y);
				return c;
			}
			public static Complex operator *(Complex x, Complex y) //fuction for overloading *
			{
				Complex c = new Complex(x.x * y.x, x.y * y.y);
				return c;
			}
			// 1/2 : 5/4 = (1 * 4)/(2 * 5)
			public static Complex operator /(Complex x, Complex y) //function for overloading /
			{
				Complex c = new Complex(x.x * y.y, y.x * x.y);
				return c;
			}
		}
		static void Main(string[] args)
		{
			Complex a = new Complex(1, 2);
			Complex b = new Complex(2, 3);

			Complex sum = a + b;
			Complex sub = a - b;
			Complex mult = a * b;
			Complex div = a / b;

			FileStream fa = new FileStream("sum.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			BinaryFormatter ba = new BinaryFormatter();
			ba.Serialize(fa, sum);
			fa.Close();

			FileStream fb = new FileStream("sub.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			BinaryFormatter bb = new BinaryFormatter();
			bb.Serialize(fb, sum);
			fb.Close();

			FileStream fc = new FileStream("mult.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			BinaryFormatter bc = new BinaryFormatter();
			bc.Serialize(fc, sum);
			fc.Close();

			FileStream fd = new FileStream("div.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			BinaryFormatter bd = new BinaryFormatter();
			bd.Serialize(fd, sum);
			fd.Close();

			//show results 
			//we rewrited ToString, so we can just write variables we want to output
			Console.WriteLine("Sum="+sum);
			Console.WriteLine("Substraction=" + sub);
			Console.WriteLine("Multiplication=" + mult);
			Console.WriteLine("Division=" + div);
			Console.ReadKey();
		}
	}
}