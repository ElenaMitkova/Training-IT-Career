using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Преобразуване_на_масив_в_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (arr.Length>1)
            {
                while (arr.Length > 1)
                {
                    int[] newArr = new int[arr.Length - 1];
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        newArr[i] = arr[i] + arr[i + 1];
                    }
                    arr = newArr;
                }
                Console.WriteLine(String.Join(" ", arr));
            }
            else
            {
                Console.WriteLine($"{String.Join(" ", arr)} is already condensed to number");
            }
        }
    }
}