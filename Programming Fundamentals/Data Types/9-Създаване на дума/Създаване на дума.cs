using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _9_Създаване_на_дума
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string word = "";
            while (n > 0)
            {
                char symbol = char.Parse(Console.ReadLine());
                word += symbol;
                n--;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}