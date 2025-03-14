using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MaxNumber
{
    internal class MaxNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double number = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                double number1 = double.Parse(Console.ReadLine());
                if (number1 > number)
                {
                    number = number1;
                }
            }
            Console.WriteLine(number);
        }
    }
}