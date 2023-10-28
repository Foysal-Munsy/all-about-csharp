using System;
namespace Polymorphism
{
    public abstract class Shape
    {
        private string name;
        public Shape(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public abstract double getArea();
    }
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius,string name) :base(name)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            return 3.1416 * (radius * radius);
        }
    }
    public class Rectangle:Shape
    {
        private double length, width;
        public Rectangle(string name,double length, double width):base(name)
        {
            this.length = length;
            this.width = width;
        }
        public override double getArea()
        {
            return length * width;
        }
    }
    public class Program
    {
        static void Main(string[]args)
        {
            Circle circle = new Circle(5,"Circle");
            Console.WriteLine(circle.getName() + " Area: " + circle.getArea());

            Rectangle rectangle = new Rectangle("Rectangle", 4, 6);           
            Console.WriteLine(rectangle.getName() + " Area: " + rectangle.getArea());

            Console.ReadLine();
        }
    }
}

