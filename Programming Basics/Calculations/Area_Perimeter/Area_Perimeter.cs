using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Area_Perimeter
{
    internal class Area_Perimeter
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.Round(Math.PI * r * r, 2);
            double perimeter = Math.Round(2 * Math.PI * r, 2);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }
    }
}
