using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
namespace _2___Метод_Insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // O(1)
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());
            list.Add(number);
            Console.WriteLine(string.Join(" ",list));
            list.Sort();
            Console.WriteLine(string.Join(" ",list));
        }
    }
}