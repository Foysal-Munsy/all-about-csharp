using System;
namespace Lab_04
{
	public class Book
	{
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public void display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}");
        }
    }
}

