using System;
namespace Lab__Task_05
{
	public class Student:Human
	{
		public string name;
		public float cgpa;
		public Student(string name, float cgpa,int age):base(age)
		{
			this.name = name;
			this.cgpa = cgpa;
		}
		public void display()
		{
            Console.WriteLine("Student information:");
            Console.WriteLine("Name: " + name);
			Console.WriteLine("CGPA: " + cgpa);
			Console.WriteLine("Age: " + age);
		}
	}
}

