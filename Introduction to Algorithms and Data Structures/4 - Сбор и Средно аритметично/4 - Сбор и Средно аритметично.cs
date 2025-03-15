using System;
using System.Linq;
namespace _4___Сбор_и_Средно_аритметично
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // O(1);
            Console.WriteLine($"Sum={array.Sum()}; Average={array.Average():f2}");
        }
    }
}