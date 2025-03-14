using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace EqualCouples
{
    internal class EqualCouples
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 + number2;

            int diff = 0;



            for (int i = 2; i <= n; i++)
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
                int sum1 = number1 + number2;
                if (Math.Abs(sum1 - sum) > diff)
                {
                    diff = Math.Abs(sum1 - sum);
                }
                sum = sum1;


            }
            if (diff == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}