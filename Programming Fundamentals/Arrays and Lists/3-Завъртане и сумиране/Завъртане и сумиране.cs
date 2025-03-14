using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Завъртане_и_сумиране
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] newarr = new int[arr.Length];
            int[] sum = new int[arr.Length];

            for (int i = 0; i < n; i++)
            {
                newarr[0] = arr[arr.Length - 1];

                for (int j = 1; j < arr.Length; j++)
                {
                    newarr[j] = arr[j - 1];
                }

                for (int j = 0; j < arr.Length; j++)
                {
                    sum[j] += newarr[j];
                }

                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = newarr[j];
                }
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}