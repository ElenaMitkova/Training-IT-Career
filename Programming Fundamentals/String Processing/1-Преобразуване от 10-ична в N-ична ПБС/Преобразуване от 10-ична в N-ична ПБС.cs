using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1_Преобразуване_от_10_ична_в_N_ична_ПБС
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int baseToConvert = intput[0], number = intput[1];
            List<int> list = new List<int>();
            while (number > 0)
            {
                int num = number % baseToConvert;
                list.Add(num);
                number /= baseToConvert;
            }
            list.Reverse();
            Console.WriteLine(string.Join("",list));
        }
    }
}