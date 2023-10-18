using System;
namespace BirdCanFly
{
    public class Bird
    {
        public bool fly;
        public void can_fly(bool fly)
        {
            this.fly = fly;
        }
        public void display()
        {
            if(this.fly)
            {
                Console.WriteLine("This bird can fly.");
            }
            else
            {
                Console.WriteLine("This bird cannot fly.");
            }
        }

    }
    public class Robin : Bird
    {
        public Robin()
        {
            can_fly(true);
        }
    }
    public class Penguine : Bird
    {
        public Penguine()
        {
            can_fly(false);
        }
    }

    public class Program
	{
        public static void Main(string[] args)
        {
            Robin robin = new Robin();
            robin.display();
            Penguine penguine = new Penguine();
            penguine.display();
            Console.ReadLine();
        }
    }
}

