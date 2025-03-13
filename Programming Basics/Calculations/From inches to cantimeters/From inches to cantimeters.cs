using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace From_inches_to_cantimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches: ");
            double inches = double.Parse(Console.ReadLine());
            double cantimeters = inches * 2.54;
            Console.WriteLine($"Cantimeters: {cantimeters}");
        }
    }
}