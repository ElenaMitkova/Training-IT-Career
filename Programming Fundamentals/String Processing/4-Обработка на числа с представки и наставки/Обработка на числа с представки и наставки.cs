using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Обработка_на_числа_с_представки_и_наставки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]texts = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double suma = 0;
            foreach (string item in texts)
            {
                char first = item[0], last = item[item.Length - 1];
                double number = double.Parse(item.Substring(1,item.Length-2));
                if (Char.IsLower(first) && first >= 'a' && first <= 'z')
                {
                    number *= (first - 'a' + 1);
                }
                else
                {
                    number /= (first - 'A' + 1);
                }
                if (Char.IsLower(last) && last >= 'a' && last <= 'z')
                {
                    number += (last - 'a' + 1);
                }
                else
                {
                    number -= (last - 'A' + 1);
                }
                suma+= number;  
            }
            Console.WriteLine($"{suma:f2}") ;
        }
    }
}