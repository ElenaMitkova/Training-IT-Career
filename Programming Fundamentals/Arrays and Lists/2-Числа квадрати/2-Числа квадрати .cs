using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Числа_квадрати
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0,j=0; i < numbers.Length; i++)
            {
                if (Math.Sqrt(numbers[i])%1==0)
                {
                    if (j==0)
                    {
                        Console.Write(numbers[i]);
                        j++;
                    }
                    else
                    {
                        Console.Write($" {numbers[i]}");
                    }
                }
            }
        }
    }
}