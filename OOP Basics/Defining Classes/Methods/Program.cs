using System;
using System.Collections.Generic;
using ProblemMethods;

namespace ProblemPersonAndHisMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods person = new Methods();
            person.Name = "Test";
            person.Age = 4;

            int accountsCount = int.Parse(Console.ReadLine());

            person.Accounts = new List<BankAccount>();
            for (int i = 0; i < accountsCount; i++)
            {
                BankAccount account = new BankAccount();
                account.Id = i;
                account.Balance = double.Parse(Console.ReadLine());

                person.Accounts.Add(account);
            }

            Console.WriteLine(person.GetBalanced());
        }
    }
}
