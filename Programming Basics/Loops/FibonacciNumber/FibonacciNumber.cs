using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FibonacciNumber
{
    internal class FibonacciNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                int f0 = 1, f1 = 1, newnumber = 0;
                for (int i = 1; i < number; i++)
                {
                    newnumber = f0 + f1;
                    f0 = f1;
                    f1 = newnumber;
                }
                Console.WriteLine(newnumber);
            }
        }
    }
}