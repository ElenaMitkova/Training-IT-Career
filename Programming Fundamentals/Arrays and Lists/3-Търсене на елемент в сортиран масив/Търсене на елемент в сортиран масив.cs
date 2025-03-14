using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Търсене_на_елемент_в_сортиран_масив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchedNumber = int.Parse(Console.ReadLine());
            bool isThere = false;
            foreach (int i in array)
            {
                if (i == searchedNumber)
                {
                    isThere = true;
                }
            }
            if (isThere)
            {
                Console.WriteLine($"Yes");
            }
            else
            {
                Console.WriteLine($"No");
            }
        }
    }
}