using System;
using Lab_04;

public class Program
{
    
    public static void Main(string[] args)
    {

        //For Book Class
        Book myBook = new Book("One Piece", "Foysal Munsy ", 1000.99);
        myBook.display();
        Console.WriteLine();

        //For Bank Account Class
        BankAccount myAccount = new BankAccount("22-47225-1", "Foysal Munsy", 5000.00);

        myAccount.Deposit(2000.00);
        myAccount.DisplayBalance();
        Console.WriteLine("After Withdraw: ");
        myAccount.Withdraw(1500.00);
        myAccount.DisplayBalance();
        Console.WriteLine();


        //For product Class
        Product myProduct = new Product("Book", 1000.00, 3);

        double totalCost = myProduct.calculateCost();
        Console.WriteLine($"Total cost of products in stock: {totalCost}");
        Console.ReadLine();
    }
}