using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PersonAndHisMoney
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<BankAccount>BankAccounts { get; } = new List<BankAccount>();
        public decimal GetBalance()
        {
            return BankAccounts.Sum(x => x.Balance);
        }
    }
}