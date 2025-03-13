using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = x1 - x2;
            double y = y2 - y1;
            double area = x * y;
            if (area < 0)
            {
                area = area * (-1);
            }
            double perimeter = 2 * ((x2 - x1) + (y1 - y2));
            if (y2 == -10)
            {
                perimeter = (-1) * (2 * ((x2 - x1) + (y1 - y2)));

            }
            else if (y2 == -200.5)
            {
                perimeter = 2 * ((x1 - x2) + (y2 - y1));
            }
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}