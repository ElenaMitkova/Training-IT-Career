using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NumberInRange1_100
{
    internal class NumberInRange1_100
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the range [1...100]: ");
            int number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)
            {
                if (number >= 1 && number <= 100)
                {
                    Console.WriteLine($"The number is: {number}");
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
                Console.WriteLine("Enter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());

            }
            if (number >= 1 && number <= 100)
            {
                Console.WriteLine($"The number is: {number}");
            }
        }
    }
}