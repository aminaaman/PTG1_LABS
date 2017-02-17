using System;

namespace Student
{
	class Program
	{
		class Student //creating class Student
		{
			public string name;     //student's info
			public string surname;
			public int age;
			public double gpa;

			public Student(string name, string surname, int age, double gpa) //constructor that initializes info
			{
				this.name = name;
	     		this.surname = surname;
				this.age = age;
				this.gpa = gpa;
			}

			public override string ToString() //function that outputs data as a string
			{
				return name + " " + surname + " " + age + " " + gpa;
			}
		}

		static void Main(string[] args)
		{
			Student s = new Student("Amina", "Aman", 25, 3.8); //creating a new variable
			Console.WriteLine(s); //output by ToString
			Console.ReadKey();
		}
	}
}
