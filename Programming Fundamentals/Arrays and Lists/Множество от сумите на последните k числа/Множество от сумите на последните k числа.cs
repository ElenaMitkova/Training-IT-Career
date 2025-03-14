using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Множество_от_сумите_на_последните_k_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int[]array = new int[n];
            byte k = byte.Parse(Console.ReadLine());
            array[0] = 1;
            for (int i = 1; i < n; i++)
            {
                int sum = 0;
                for (int j = i-1; j >= Math.Max(i-k,0); j--)
                {
                    sum+= array[j];
                }
                array[i] = sum;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}