using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1_Умножаване_на_четни_по_нечетни
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultiplyOfSumOfEvenNumbersAndSumOfEvenNumbers(number));
        }
        static int GetsumOfEvenNumbers(int number)
        {
            int evenSum = 0;
            if (number > 0)
            {
                while (number > 0)
                {
                    int ost = number % 10;
                    if (ost % 2 == 0)
                    {
                        evenSum += ost;
                    }
                    number /= 10;
                }
            }
            else
            {
                number *= -1;
                while (number > 0)
                {
                    int ost = number % 10;
                    if (ost % 2 == 0)
                    {
                        evenSum += ost;
                    }
                    number /= 10;
                }
            }
            return evenSum;
        }
        static int GetsumOfOddNumbers(int number)
        {
            int oddSum = 0;
            if (number>0)
            {
                while (number > 0)
                {
                    int ost = number % 10;
                    if (ost % 2 == 1)
                    {
                        oddSum += ost;
                    }
                    number /= 10;
                }
            }
            else
            {
                number *= -1;
                while (number > 0)
                {
                    int ost = number % 10;
                    if (ost % 2 == 1)
                    {
                        oddSum += ost;
                    }
                    number /= 10;
                }
            }
            return oddSum;
        }
        static int GetMultiplyOfSumOfEvenNumbersAndSumOfEvenNumbers(int number)
        {
            int oddSums = GetsumOfOddNumbers(number);
            int evenSums = GetsumOfEvenNumbers(number);
            return oddSums * evenSums;
        }
    }
}