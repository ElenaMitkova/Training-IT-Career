using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ThreeEqualNumbers
{
    internal class ThreeEqualNumbers
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            if (number1 == number2 && number1 == number3 && number3 == number1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}