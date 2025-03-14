using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Max_Of_2
{
    internal class Max_Of_2
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            if (number > number2)
            {
                Console.WriteLine("Greater number = " + number);
            }
            else
            {
                Console.WriteLine("Greater number = " + number2);
            }
        }
    }
}