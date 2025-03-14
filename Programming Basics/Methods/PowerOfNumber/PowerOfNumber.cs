using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PowerOfNumber
{
    internal class PowerOfNumber
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(number,power));
        }
        static double Power(double number,int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *=number;
            }
            return result;
        }
    }
}