using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Odd_Or_Even
{
    internal class Odd_Or_Even
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}