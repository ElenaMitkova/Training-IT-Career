using System;
using System.Collections.Generic;
using System.Text;
namespace ProblemMethods
{
    internal class BankAccount
    {
        public int id;
        public double balance;
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
        public void Deposit(double amaunt)
        {
            balance += amaunt;
        }
        public void Withdraw (double amaunt)
        {
            balance -= amaunt;
        }
        public override string ToString()
        {
            return $"Account {Id}, balance {Balance}";
        }
    }
}