using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _8_Строител
{
    internal class Строител
    {
        static void Main(string[] args)
        {
            long firstNumber = int.Parse(Console.ReadLine());
            long secondNumber = int.Parse(Console.ReadLine());
            long suma = 0;
            if (firstNumber > secondNumber)
            {
                suma = secondNumber * 4 + firstNumber * 10;
            }
            else
            {
                suma = firstNumber * 4 + secondNumber * 10;
            }
            Console.WriteLine(suma);
        }
    }
}