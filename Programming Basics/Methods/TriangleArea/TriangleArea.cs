using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TriangleArea
{
    internal class TriangleArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Area(a, b));
        }
        static double Area(double a, double b)
        {
            double area = (a * b) / 2;
            return area;
        }
    }
}