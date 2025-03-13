using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Triangle_Area
{
    internal class Triangle_Area
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = Math.Round(a * h / 2, 2);
            Console.WriteLine($"Triangle area: {area}");
        }
    }
}
