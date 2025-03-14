using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Брой_на_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(new[] {' ',',',':'},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count-1; j++)
                {
                    if (list[j] > list[j+1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            int count = 0, number = list[0];
            foreach (int i in list)
            {
                if (i == number)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{number} -> {count}");
                    count = 1;
                    number = i;
                }
            }
            Console.WriteLine($"{number} -> {count}");
        }
    }
}