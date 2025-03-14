using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Специални_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = 1;
            while (number >= n)
            {
                int num1 = n / 10;
                int num2 = n % 10;
                if (num1 + num2 == 5 || num1 + num2 == 7 || num1 + num2 == 11)
                {
                    Console.WriteLine($"{n} -> True");
                }
                else
                {
                    Console.WriteLine($"{n} -> False");
                }
                n++;
            }
        }
    }
}