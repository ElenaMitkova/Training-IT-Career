using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EvenOddSumMultiplicatio_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(Math.Abs(EvenSum(number)* OddSum(number)));
        }
        static int EvenSum(int number)
        {
            int sum = 0;
            int ostatac=0;
            while (number > 0)
            {
                ostatac = number % 10;
                if (ostatac%2==0)
                {
                    sum += ostatac;
                }
                number /= 10;
            }
            return sum;
        }
        static int OddSum(int number)
        {
            int sum = 0;
            int ostatac = 0;
            while (number > 0)
            {
                ostatac = number % 10;
                if (ostatac % 2 == 1)
                {
                    sum += ostatac;
                }
                number /= 10;
            }
            return sum;
        }
    }
}