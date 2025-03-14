using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Туристическа_информация
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mqra = Console.ReadLine();
            double stoinost = double.Parse(Console.ReadLine());
            switch (mqra)
            {
                case "miles":
                    double kilometers = stoinost * 1.6;
                    Console.WriteLine($"{stoinost} miles = {kilometers:f2} kilometers");
                    break;
                case "inches":
                    double centimeters = stoinost * 2.54;
                    Console.WriteLine($"{stoinost} inches = {centimeters:f2} centimeters");
                    break;
                case "feet":
                    double centimeter = stoinost * 30;
                    Console.WriteLine($"{stoinost} feet = {centimeter:f2} centimeters");
                    break;
                case "yards":
                    double meters = stoinost * 0.91;
                    Console.WriteLine($"{stoinost} yards = {meters:f2} meters");
                    break;
                case "gallons":
                    double liters = stoinost * 3.8;
                    Console.WriteLine($"{stoinost} gallon = {liters:f2} liters");
                    break;
            }
        }
    }
}