using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serilization //Serialization sohranenie sostoyaniya ob'ekta
{
	[Serializable]
	public class Subject
	{
		public string name;
		public Subject() { }
		public Subject(string name)
		{
			this.name = name;
		}
	}
	[Serializable]
	public class Student
	{
		public string name;
		public string surname;
		public int age;
		public List<Subject> subjects;

		public Student() { }
		public Student(string name, string surname, int age)
		{
			this.name = name;
			this.surname = surname;
			this.age = age;
			subjects = new List<Subject>();
			subjects.Add(new Subject("Programming Languages"));
			subjects.Add(new Subject("Programming Technologies"));

		}
	}
	class MainClass
	{
		
		static void F3()
		{
			FileStream fs = new FileStream("example.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			BinaryFormatter bf = new BinaryFormatter();
			Student student = new Student("Almas", "Abeuov", 23);
			bf.Serialize(fs, student);
			fs.Close();

		}
		static void F4()
		{
			FileStream fs = new FileStream("example.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			BinaryFormatter bf = new BinaryFormatter();
			Student student = bf.Deserialize(fs) as Student;
			foreach (Subject sub in student.subjects)
			{
				Console.WriteLine(sub.name);
			}
			Console.ReadKey();
		}

		public static void Main(string[] args)
		{
			F4();
		}
	}
}
