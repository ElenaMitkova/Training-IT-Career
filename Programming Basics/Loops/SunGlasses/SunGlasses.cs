using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SunGlasses
{
    internal class SunGlasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
            for (int d = 1; d <= n - 2; d++)
            {

                if (d == Math.Abs(((n - 1) / 2)))
                {
                    Console.WriteLine("*" + new string('/', (2 * n) - 2) + "*" + new string('|', n) + "*" + new string('/', (2 * n) - 2) + "*");
                }
                else
                {
                    Console.WriteLine("*" + new string('/', (2 * n) - 2) + "*" + new string(' ', n) + "*" + new string('/', (2 * n) - 2) + "*");
                }
            }
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        
    }
    }
}