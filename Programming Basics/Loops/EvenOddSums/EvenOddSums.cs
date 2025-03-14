using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EvenOddSums
{
    internal class EvenOddSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                double number1 = double.Parse(Console.ReadLine());
                if(i%2==1)
                {
                    sum += number1;
                }
                else if(i%2==0)
                {
                    sum2 += number1;
                }
            }
            if (sum == sum2)
            {
                Console.WriteLine($"Yes, Sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No, Diff = {Math.Abs(sum2 - sum)}");
            }
        }
    }
}