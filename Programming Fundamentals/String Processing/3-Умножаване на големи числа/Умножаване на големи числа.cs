using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace _3_Умножаване_на_големи_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            string newNumber = "";
            int mul = int.Parse(multiplier.ToString()), res = 0;
            for (int i = number.Length-1; i >= 0; i--)
            {
                res = res + (number[i]-'0') * multiplier;
                newNumber = (res % 10).ToString() + newNumber;
                res = res / 10;
            }
            if (res > 0)
            {
                newNumber = res + newNumber;
            }
            Console.WriteLine(newNumber);
        }
    }
}