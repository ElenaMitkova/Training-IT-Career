using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EvenNumberWithCheck
{
    internal class EvenNumberWithCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Enter even number: ");
            int number;
            while (true)
            {
                try
                {

                    number = int.Parse(Console.ReadLine());
                    if (number % 2 != 0)
                    {
                        Console.Write("Invalid number!");
                        number = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid number!");
                }

            }
            Console.WriteLine($"Even number entered: {number}");
        }
    }
}