using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Най_често_срещано_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array = new int[655356];
            int number = arr[0], maxCount = 1;
            foreach (var item in arr)
            {
                array[item]++;
                if (array[item] > maxCount)
                {
                    number = item;
                    maxCount = array[item];
                }
            }
            Console.WriteLine(number);
        }
    }
}