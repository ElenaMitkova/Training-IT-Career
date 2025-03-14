using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TheLCD__NOD_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int nod = 0;
            for (int i = 1; i <= number1 || i <= number2; i++)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    nod = i;
                }
            }
            Console.WriteLine(nod);
        }
    }
}