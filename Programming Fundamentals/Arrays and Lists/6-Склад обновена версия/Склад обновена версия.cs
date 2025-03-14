using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _6_Склад_обновена_версия
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] things = Console.ReadLine().Split(' ').ToArray();
            int[] kol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double[] price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            string[] thing = Console.ReadLine().Split();
            while (thing[0] != "done")
            {
                int kolichestvo = int.Parse(thing[1]);
                for (int i = 0; i < things.Length; i++)
                {
                    if (things[i] == thing[0])
                    {
                        if (i >= kol.Length - 1 || kol[i] < kolichestvo)
                        {
                            Console.WriteLine($"We do not have enough {thing[0]}");
                        }
                        else
                        {
                            Console.WriteLine($"{things[i]} x {kolichestvo} costs {(kolichestvo * price[i]):f2}");
                            kol[i] -= kolichestvo;
                        }
                    }
                }
                thing = Console.ReadLine().Split();
            }
        }
    }
}