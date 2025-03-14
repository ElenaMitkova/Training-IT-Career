using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FigureArea
{
    internal class FigureArea
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    double area = a * a;
                    Console.WriteLine(area);
                    break;
                case "rectangle":
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    double area1 = b * c;
                    Console.WriteLine(area1);
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    double area2 = Math.PI * r * r;
                    Console.WriteLine(area2);
                    break;
                case "triangle":
                    double n = double.Parse(Console.ReadLine());
                    double m = double.Parse(Console.ReadLine());
                    double area3 = m * n / 2;
                    Console.WriteLine(area3);
                    break;
            }
        }
    }
}