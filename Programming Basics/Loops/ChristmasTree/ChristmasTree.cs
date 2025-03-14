using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChristmasTree
{
    internal class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string(' ', n));
            Console.WriteLine("|");
            for (int d = 1; d <= n; d++)
            {
                Console.Write(new string(' ', n - d));
                Console.Write(new string('*', d));
                Console.WriteLine("|" + new string('*', d));

            }
        }
    }
}