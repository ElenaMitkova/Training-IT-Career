using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Преливане_на_вода
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255, ost=0;
            while (n > 0)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    ost = ost + liters;
                    capacity = capacity - liters;
                }
                n--;
            }
            Console.WriteLine(ost);
        }
    }
}