﻿using System;
using System.Collections.Generic;
using System.Text;
namespace ProblemBankAccount
{
    internal class BankAccount
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
    }
}