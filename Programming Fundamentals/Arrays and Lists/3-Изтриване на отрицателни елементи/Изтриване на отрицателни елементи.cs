using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Изтриване_на_отрицателни_елементи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(new[] {' ',',',':'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondList = new List<int>();
            foreach (int i in list)
            {
                if (i<0)
                {

                }
                else
                {
                    secondList.Add(i);
                }
            }
            if (secondList.Count == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                for (int i = secondList.Count-1;i>=0;i--)
                {
                    if(i==secondList.Count-1)
                    {
                        Console.Write(secondList[i]);
                    }
                    else
                    {
                        Console.Write($" {secondList[i]}");
                    }
                }
            }
        }
    }
}