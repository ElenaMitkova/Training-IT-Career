using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Изчертаване_на_запълнен_квадрат
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            FirstAndLastLine(number);
            for (int i = 0;i<number-2;i++)
            {
                MiddlePart(number);
            }
            FirstAndLastLine(number);
        }
        static void FirstAndLastLine(int number)
        {
            Console.WriteLine(new string('-',number*2));
        }
        static void MiddlePart(int number)
        {
            Console.Write('-');
            for (int i = 2; i <= number; i++)
            {
                Console.Write("\\/");
            }
            Console.Write('-');
            Console.WriteLine();
        }
    }
}
