using System;
public class oop2
{
    public struct student
    {
        public int id;
        public int semester;
        public double credit;
        public double cgpa;
        public void display()
        {
            if(cgpa >= 3.75)
            {
                Console.Write("Scholarship holder id: " +id + " cgpa: " + cgpa + " ");
                Console.WriteLine();
            }
            else if(cgpa < 3.75)
            {
                Console.Write("Scholarship is not available for- id: " + id + " cgpa: " + cgpa + " ");
                Console.WriteLine();
            }
            if(credit > 50)
            {
                Console.WriteLine("ID: " + id + " Credit complete: " + credit);
                Console.WriteLine();
            }
            if(semester >=2 && credit >=28)
            {
                Console.WriteLine("ID: " + id + " Credit complete: " + credit + " Complete Semester: " + semester);
                Console.WriteLine();
            }
        }
    }
    public static void Main(string[] args)
    {
        student s1, s2, s3, s4, s5;
        //student 1
        s1.id = 21;
        s1.semester = 2;
        s1.credit = 50;
        s1.cgpa = 3.82;
        
        //student 2
        s2.id = 22;
        s2.semester = 5;
        s2.credit = 76;
        s2.cgpa = 3.56;
        //student 3
        s3.id = 23;
        s3.semester = 7;
        s3.credit = 90;
        s3.cgpa = 3.93;
        //student 4
        s4.id = 24;
        s4.semester = 1;
        s4.credit = 14;
        s4.cgpa = 3.33;
        //student 5
        s5.id = 25;
        s5.semester = 6;
        s5.credit = 69;
        s5.cgpa = 3.76;

        //output
        s1.display();
        s2.display();
        s3.display();
        s4.display();
        s5.display();
        Console.ReadLine();
    }
}