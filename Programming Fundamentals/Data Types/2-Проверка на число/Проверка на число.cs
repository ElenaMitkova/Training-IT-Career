using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Проверка_на_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number =decimal.Parse(Console.ReadLine());
            if (number %1 == 0)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}