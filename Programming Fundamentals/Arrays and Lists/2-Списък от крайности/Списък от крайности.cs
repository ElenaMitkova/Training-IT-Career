using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Списък_от_крайности
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int max = int.MinValue; int min = int.MaxValue;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
                else if (list[i] < min)
                {
                    min = list[i];
                }
            }
            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = 0; j < list.Count-1; j++)
                {
                    if (list[j] > list[j+1])
                    {
                        int temp = list[j];
                        list[j] = list[j+1];
                        list[j+1] = temp;
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]==min)
                {
                    if (count==0)
                    {
                        Console.Write(list[i]);
                        count++;
                    }
                    else
                    {
                        Console.Write($" {list[i]}");
                        count++;
                    }
                }
                else if(list[i]==max)
                {
                    if (count==0)
                    {
                        Console.Write(list[i]);
                        count++;
                    }
                    else
                    {
                        Console.Write($" {list[i]}");
                        count++;
                    }
                }
            }
        }
    }
}