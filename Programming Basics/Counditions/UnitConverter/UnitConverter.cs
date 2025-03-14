using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UnitConverter
{
    internal class UnitConverter
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string convertingFrom = Console.ReadLine();
            string convertingTo = Console.ReadLine();
            switch (convertingFrom)
            {
                case "mm":
                    number = number / 1000;
                    break;
                case "cm":
                    number = number / 100;
                    break;
                case "mi":
                    number = number / 0.000621371192;
                    break;
                case "in":
                    number = number / 39.3700787;
                    break;
                case "km":
                    number = number / 0.001;
                    break;
                case "ft":
                    number = number / 3.2808399;
                    break;
                case "yd":
                    number = number / 1.0936133;
                    break;
            }
            switch (convertingTo)
            {
                case "mm":
                    number = number * 1000;
                    break;
                case "cm":
                    number = number * 100;
                    break;
                case "mi":
                    number = number * 0.000621371192;
                    break;
                case "in":
                    number = number * 39.3700787;
                    break;
                case "km":
                    number = number * 0.001;
                    break;
                case "ft":
                    number = number * 3.2808399;
                    break;
                case "yd":
                    number = number * 1.0936133;
                    break;
            }
            Console.WriteLine($"{Math.Round(number, 15)} {convertingTo}");
        }
    }
}