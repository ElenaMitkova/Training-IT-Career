using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Convert_Money
{
    internal class Convert_Money
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string convertingFrom = Console.ReadLine();
            string convertingTo = Console.ReadLine();
            switch (convertingFrom)
            {
                case "USD":
                    money = money * 1.79549;
                    break;
                case "EUR":
                    money = money * 1.95583;
                    break;
                case "GBP":
                    money = money * 2.53405;
                    break;
            }
            switch (convertingTo)
            {
                case "USD":
                    money = money / 1.79549;
                    break;
                case "EUR":
                    money = money / 1.95583;
                    break;
                case "GBP":
                    money = money / 2.53405;
                    break;
            }
            Console.WriteLine(Math.Round(money, 2));
        }
    }
}
