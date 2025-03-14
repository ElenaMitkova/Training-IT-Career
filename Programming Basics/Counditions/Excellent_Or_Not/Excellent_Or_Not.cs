using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excellent_Or_Not
{
    internal class Excellent_Or_Not
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade > 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}