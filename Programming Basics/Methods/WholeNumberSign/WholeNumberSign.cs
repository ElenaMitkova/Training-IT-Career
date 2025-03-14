using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WholeNumberSign
{
    internal class WholeNumberSign
    {
        static void Main(string[] args)
        {
            int number = int .Parse(Console.ReadLine());
            Symbol(number);
        }
        static void Symbol (int number)
        {
            if (number >0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else { Console.WriteLine($"The number {number} is zero."); }
        }
    }
}