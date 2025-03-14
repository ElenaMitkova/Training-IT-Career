using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1_Сума_на_съседни_еднакви_числа
{
    internal class Program
    {
        static void Main(string[] args)                          
        {
            List<int> list = Console.ReadLine().Split(new[] {' ',',',':'},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            for (int j = 0; j < list.Count; j++)
            {
                for (int i = 0; i < list.Count - 1; i += 2)
                {
                    if (list[i] == list[i + 1])
                    {
                        list[i + 1] *= 2;
                        list.RemoveAt(i);
                    }
                }
            }      
            Console.WriteLine(String.Join(" ", list));
        }
    }
}