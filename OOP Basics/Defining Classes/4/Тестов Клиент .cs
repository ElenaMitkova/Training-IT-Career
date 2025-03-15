using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
namespace ProblemTestClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] commands= Console.ReadLine().Split(' ').ToArray();
            Dictionary <int, BankAccountsWithDictionary> accounts = new Dictionary<int, BankAccountsWithDictionary>();
            while (commands[0]!="End")
            {
                string thisCommand = commands[0];
                switch (thisCommand)
                {
                    case "Create":
                        Create(commands,accounts);
                        break;
                    case "Deposit":
                        Deposit(commands,accounts);
                        break;
                    case "Withdraw":
                        Withdraw(commands,accounts);
                        break;
                    case "Print":
                        Print(commands,accounts);
                        break;
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }
        }
        static void Create (string []command, Dictionary<int, BankAccountsWithDictionary> accounts)
        {
            int id = int.Parse(command[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
               // accounts[id] = ;
                accounts.Add(id, new BankAccountsWithDictionary(id,0));
            }
        }
        static void Deposit (string[] command, Dictionary<int, BankAccountsWithDictionary> accounts)
        {
            int id = int.Parse(command[1]);
            double amount = double.Parse(command[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Deposit(amount);          
            }
        }
        static void Withdraw(string[] command, Dictionary<int, BankAccountsWithDictionary> accounts)
        {
            int id = int.Parse(command[1]);
            double amount = double.Parse(command[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            { 
            if (amount > accounts[id].Balance)
            {
                
                
                    Console.WriteLine("Insufficient balance");
                
            }
            else
            {
                accounts[id].Withdraw(amount);
            }
            }
        }
        static void Print (string[] command, Dictionary<int, BankAccountsWithDictionary> accounts)
        {
            int id = int.Parse(command[1]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(accounts[id].ToString());
            }
        }
    }
}