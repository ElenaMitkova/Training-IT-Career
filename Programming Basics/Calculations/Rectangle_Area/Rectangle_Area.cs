using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    internal class Rectangle_Area
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y1 - y2);
            double area = a * b;
            double perimeter = 2 * (a + b);
            Console.WriteLine((area));
            Console.WriteLine((perimeter));
        }
    }
}
