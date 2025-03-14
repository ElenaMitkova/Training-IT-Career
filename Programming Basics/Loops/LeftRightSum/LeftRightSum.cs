using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LeftRightSum
{
    internal class LeftRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                double number1 = double.Parse(Console.ReadLine());
                sum += number1;
            }
            for (int i = 0;i < n; i++) 
            {
                double number2 = double.Parse(Console.ReadLine());
                sum2 += number2;
            }
            if (sum==sum2)
            {
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No , diff = {Math.Abs(sum - sum2)}");
            }
        }
    }
}