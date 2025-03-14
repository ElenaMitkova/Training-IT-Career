using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1_Списък_от_четни_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]%2==0)
                {
                    Console.Write($"{list[i]} ");
                }
            }
        }
    }
}