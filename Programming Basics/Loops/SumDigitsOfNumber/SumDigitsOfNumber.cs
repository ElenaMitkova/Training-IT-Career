using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SumDigitsOfNumber
{
    internal class SumDigitsOfNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0, ostatac = 0;
            for (int i = number; i > 0; i--)
            {
                ostatac = number % 10;
                number = number / 10;
                sum += ostatac;
            }
            Console.WriteLine(sum);
        }
    }
}