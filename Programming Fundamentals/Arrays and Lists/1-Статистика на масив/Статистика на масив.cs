using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1_Статистика_на_масив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"Min: {arr.Min()}");
            Console.WriteLine($"Max: {arr.Max()}");
            Console.WriteLine($"Sum: {arr.Sum()}");
            Console.WriteLine($"Average: {arr.Average()}");
        }
    }
}