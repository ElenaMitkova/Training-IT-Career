using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _5_Склад
{
    internal class Склад
    {
        static void Main(string[] args)
        {
            string[] things = Console.ReadLine().Split(' ').ToArray();
            int[] kol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] price = Console.ReadLine().Split(' ').ToArray().ToArray();
            string thing = Console.ReadLine();
            while (thing != "done")
            {
                for (int i = 0; i < things.Length; i++)
                {
                    if (things[i] == thing)
                    {
                        Console.WriteLine($"{thing} costs: {price[i]}; Available quantity: {kol[i]}");
                    }
                }
                thing = Console.ReadLine();
            }
        }
    }
}