using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace _1__Разклащане_на_Мелрах
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string primer = Console.ReadLine();
            int p = primer.Length, firstIndex = 0, secondIndex = 0;


            while (p > 0 && text.Length > 0)
            {
                firstIndex = text.IndexOf(primer);
                secondIndex = text.LastIndexOf(primer);
                if (firstIndex >= 0 && secondIndex >= 0 && firstIndex != secondIndex)
                {

                    text = text.Remove(firstIndex, primer.Length);
                    secondIndex = text.LastIndexOf(primer);
                    text = text.Remove(secondIndex, primer.Length);
                    Console.WriteLine("Shaked it.");
                    primer = primer.Remove(p / 2, 1);
                    p = primer.Length;
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    break;
                }

            }
            if (text.Length < 0 || primer.Length < 0)
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(text);
            }


        }
    }
}