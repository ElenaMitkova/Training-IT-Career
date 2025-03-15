using System;
using System.Collections.Generic;
using System.Text;
namespace ProblemTestClient
{
    internal class BankAccountsWithDictionary
    {
        private int id;
        private double balance;
        public int Id
        { 
            get { return id; } 
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public BankAccountsWithDictionary(int id, double balance)
        {
            Id = id;
            Balance = balance;
        }
        public BankAccountsWithDictionary()
        {
            Id = 1;
            Balance = 0;
        }
        public void Deposit(double amaunt)
        {
            balance += amaunt;
        }
        public void Withdraw(double amaunt)
        {
            balance -= amaunt;
        }
        public override string ToString()
        {
            return $"Account ID{id}, balance {balance:f2}";
        }
    }
}