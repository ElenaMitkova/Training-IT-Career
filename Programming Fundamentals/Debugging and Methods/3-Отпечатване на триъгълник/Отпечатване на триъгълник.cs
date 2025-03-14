using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Отпечатване_на_триъгълник
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Headar(number);
            Line(number);
            Footer(number);
        }
        static void Headar (int number)
        {
            for (int i = 1; i < number; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        static void Line(int number)
        {
            for (int i = 1; i <=number ; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void Footer (int number)
        {
            for (int i = number-1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}