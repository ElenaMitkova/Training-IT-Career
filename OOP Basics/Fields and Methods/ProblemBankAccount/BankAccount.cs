using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemBankAccount
{
    class BankAccount
    {
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}
        private int balance;
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
