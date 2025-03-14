using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Брой_на_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = numbers.Length-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j+1] = temp;
                    }
                }
            }
            int maxNumber = numbers[0], maxCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == maxNumber)
                {
                    maxCount++;
                }
                else
                {
                    Console.WriteLine($"{maxNumber} -> {maxCount}");
                    maxNumber = numbers[i];
                    maxCount = 1;
                }
            }
            Console.WriteLine($"{maxNumber} -> {maxCount}");
        }
    }
}