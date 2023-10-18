using System;
namespace Lab__Task_05
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Student student = new Student("Luffy",3.50f,22);
            student.display();
            Console.WriteLine();
            Console.WriteLine();
            ExStudent exStudent = new ExStudent("Zoro", 3.60f, 28, 2021);
            exStudent.display();
            Console.WriteLine();
            Console.WriteLine();


            Teacher teacher = new Teacher("Prof.", "Mustafiz", 55);
            teacher.display();
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}