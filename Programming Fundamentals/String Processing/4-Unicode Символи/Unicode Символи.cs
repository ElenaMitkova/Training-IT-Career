using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Unicode_Символи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string niz = Console.ReadLine();
            //byte[] Acii = Encoding.ASCII.GetBytes(niz);
            //byte[] uni = Encoding.Unicode.GetBytes(niz);
            //foreach (var item in niz)
            //{
            //    Console.WriteLine($"{(int)(item)}");
            //}
            foreach (int item in niz)
            {
                Console.Write($"\\u{((int)item).ToString("X4").ToLower()}");
            }
        }
    }
}