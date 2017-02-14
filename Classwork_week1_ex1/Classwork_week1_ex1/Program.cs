using System;

namespace Classwork_week1_ex1
{
	class MainClass
	{
		class Student
		{
			public string name;
			public string surname;
			public int age;
			public double gpa;

			public Student(string name, string surname, int age)
			{
				this.name = name;
				this.surname = surname;
				this.age = age;
			}

			public double GetGPA()
			{
				return gpa;
			}

		}
		public static void Main(string[] args)
		{
			//Student #1
			Student a = new Student("Eldana", "Aman", 20);
			a.gpa = 4.0;

			//Student #2
			Student b = new Student("Sholpan", "Agibetova", 21);
			b.age = 21;
			b.gpa = 3.9;

			Console.WriteLine(a.name);
			Console.WriteLine(b.name);
			Console.ReadKey();

		}
	}
}
