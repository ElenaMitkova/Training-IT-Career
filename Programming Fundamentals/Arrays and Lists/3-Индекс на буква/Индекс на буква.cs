using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace _3_Индекс_на_буква
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.Where(c => c != ' ').ToArray();
            //string[] newarr = input.Split((char[])null,StringSplitOptions.RemoveEmptyEntries);
            int p = 0;
            char o = 'a';
            for (int i = 0; i < chars.Length;)
            {
                if (chars[i] == o)
                {
                    Console.WriteLine($"{chars[i]} -> {p}");
                    i++;
                }
                else
                {
                    p++;
                    o++;

                }
            }
        }
    }
}