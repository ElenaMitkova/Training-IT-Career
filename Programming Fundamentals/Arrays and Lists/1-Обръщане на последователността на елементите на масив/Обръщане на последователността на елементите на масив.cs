using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace _1_Обръщане_на_последователността_на_елементите_на_масив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[]arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }
            for (int i = arr.Length-1;i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}