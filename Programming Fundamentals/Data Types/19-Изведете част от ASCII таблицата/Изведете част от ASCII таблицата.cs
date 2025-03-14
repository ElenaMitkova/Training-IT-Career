using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _19_Изведете_част_от_ASCII_таблицата
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            char symbol;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                symbol = (char)i;
                Console.Write($"{symbol} ");
            }
        }
    }
}