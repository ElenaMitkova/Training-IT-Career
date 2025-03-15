using System;
namespace ProblemBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Id = int.Parse(Console.ReadLine());
            account.Balance = double.Parse(Console.ReadLine());
            Console.WriteLine($"Account {account.Id}, balance {account.Balance}");
        }
    }
}
