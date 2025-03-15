using System;
using System.Linq;
namespace _5___Намиране_на_най_малко_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // O(1)
            Console.WriteLine(array.Min());
        }
    }
}