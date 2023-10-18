using System;
namespace Lab__Task_05
{
	public class Teacher : Human
	{
		public string name;
		public string title;
		public Teacher(string title, string name, int age) : base(age)
		{
			this.title = title;
			this.name = name;
		}
		public void display()
		{
			Console.WriteLine("Teachers info:");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            
        }
	}
}

