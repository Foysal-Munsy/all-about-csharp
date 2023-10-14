using System;
namespace Lab_04
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string accountNumber, string accountHolder, double initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Balance is not available.");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Current balance: {Balance}");
        }
    }

}

