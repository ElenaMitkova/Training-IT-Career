using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NumbersFromNto1
{
    internal class NumbersFromNto1
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}