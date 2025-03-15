using System;
namespace ProblemMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Id = int.Parse(Console.ReadLine());
            account.Deposit(double.Parse(Console.ReadLine()));
            account.Withdraw(double.Parse(Console.ReadLine()));
            Console.WriteLine(account.ToString());
        }
    }
}