using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Правоъгълник
{
    internal class Правоъгълник
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double diagonal = Math.Sqrt(a * a + b * b);
            Console.WriteLine(2*a+2*b);
            Console.WriteLine(a*b);
            Console.WriteLine(diagonal);
        }
    }
}