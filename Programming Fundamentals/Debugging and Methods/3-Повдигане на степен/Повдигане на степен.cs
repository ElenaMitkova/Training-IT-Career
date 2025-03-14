using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Повдигане_на_степен
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(ToPow(number,pow));
        }
        static int ToPow (int number,int pow)
        {
            int newNumber = 1;
            for (int i = 0; i < pow; i++)
            {
                newNumber *= number;
            }
            return newNumber;
        }
    }
}