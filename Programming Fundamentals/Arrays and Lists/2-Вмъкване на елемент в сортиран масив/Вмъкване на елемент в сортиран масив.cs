using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Вмъкване_на_елемент_в_сортиран_масив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int[]arr = new int[array.Length+1];
            arr[0] = number;
            for(int i = 1; i < arr.Length; i++)
            {
                arr[i] = array[i-1];
            }
            Array.Sort(arr);
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}