using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SumOfTheOthers
{
    internal class SumOfTheOthers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int c = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
                if (number > c)
                {
                    c = number;
                }
            }
            if (sum - c == c)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum: {c}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff: {Math.Abs(c - (sum - c))}");
            }
        }
    }
}