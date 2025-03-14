using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Точна_сума_на_реални_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal suma = 0;
            while (n > 0)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                suma = suma + number;
                n--;
            }
            Console.WriteLine(suma);
        }
    }
}