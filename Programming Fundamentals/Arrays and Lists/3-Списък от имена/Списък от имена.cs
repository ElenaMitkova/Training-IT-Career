using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Списък_от_имена
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            for (int i = list.Count-1; i >=0; i--)
            {
                if (i==0)
                {
                    Console.Write($"{list[i]} ");
                }
                else
                {
                    Console.Write($"{list[i]}; ");
                }
            }
        }
    }
}