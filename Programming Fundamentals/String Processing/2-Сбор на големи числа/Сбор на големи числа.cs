using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Сбор_на_големи_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            int  len1 = firstNumber.Length, len2 = secondNumber.Length;
            if (len1 > len2)
            {
                secondNumber = new string('0', len1 - len2) + secondNumber;
            }
            else if (len2 > len1)
            {
                firstNumber = new string('0', len2 - len1+1) + firstNumber;
            }
            Console.WriteLine(firstNumber + " " +secondNumber);
            int prenasqne = 0;
            string result = "";
            for (int i = secondNumber.Length-1; i >= 0; i--)
            {
                prenasqne = prenasqne + (firstNumber[i] - '0') + (secondNumber[i] - '0');
                result = (prenasqne % 10).ToString() + result;
                prenasqne = prenasqne / 10;
            }
            if (prenasqne > 0)
            {
                result = "1" +result;
            }
            Console.WriteLine(result);
        }
    }
}