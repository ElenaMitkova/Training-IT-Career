using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Извличане_на_средните_1__2_или_3_елемента
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (array.Length - 1 == 0)
            {
                Console.WriteLine("{ " + String.Join(" ", array) + " }");
            }
            else if (array.Length % 2 == 0)
            {
                Console.WriteLine("{ " + String.Join(", ", array[array.Length / 2], array[array.Length / 2 - 1]) + " }");
            }
            else if (array.Length % 2 == 1)
            {
                Console.WriteLine("{ " + String.Join(", ", array[array.Length / 2 - 1], array[array.Length / 2], array[array.Length / 2 + 1]) + " }");
            }
        }
    }
}