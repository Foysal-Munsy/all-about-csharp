using System;
namespace Lab__Task_05
{
	public class ExStudent : Student
    {

		public int graduationYear;
		public ExStudent(string name, float cgpa, int age, int graduationYear) :base(name,cgpa,age)
		{
			this.graduationYear = graduationYear;
		}
        public void display()
        {
            Console.WriteLine("Ex student information:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("CGPA: " + cgpa);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Graduation Year: " + graduationYear);
        }
    }
}

