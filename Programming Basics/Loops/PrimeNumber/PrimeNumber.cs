using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PrimeNumber
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else if (number == 10)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                bool notPrime = true;
                for (int i = 1; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        notPrime = false;
                    }
                    else
                    {
                        notPrime = true;
                    }
                }
                if (notPrime)
                {
                    Console.WriteLine("Prime");
                }
                else { Console.WriteLine("Not Prime"); }
            }
        }
    }
}