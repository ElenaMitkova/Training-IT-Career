using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Сливане_на_списъци
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|').ToList();
            List<int> result = new List<int>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                List<int> reversed = list[i].Split(new[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int j = 0; j < reversed.Count; j++)
                {
                    result.Add(reversed[j]);
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(result[i]);
                }
                else 
                {
                    Console.Write($" {result[i]}");
                }
            }
        }
    }
}