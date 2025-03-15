using System;
using System.Collections.Generic;
using System.Text;
using ProblemMethods;
namespace ProblemPersonAndHisMoney
{
    internal class Methods
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public List<BankAccount> Accounts
        {
            get
            {
                return accounts;
            }
            set
            {
                accounts = value;
            }
        }
        public Methods(string name,int age, List<BankAccount> Accounts)
        {
            Name = name;
            Age = age;
            Accounts = accounts;
        }
        public Methods() 
        {
            Name = "noName";
            Age = 0;
            Accounts = new List<BankAccount>();
        }
        public double GetBalanced()
        {
            double balance = 0;
            foreach (var item in Accounts)
            {
                balance += item.Balance;
            }
            return balance;
        }
        public override string ToString()
        {
            return $"name : {Name} , age: {Age}";
        }
    }
}