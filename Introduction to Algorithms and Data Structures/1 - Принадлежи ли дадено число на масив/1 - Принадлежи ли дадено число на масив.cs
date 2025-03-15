using System;
using System.Linq;
namespace _1___Принадлежи_ли_дадено_число_на_масив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            //O(1)
            if (array.Contains(number)) Console.WriteLine($"{number} Exists in the List");
            else Console.WriteLine($"{number}  Not exists in the List");
        }
    }
}