using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InvalidNumber
{
    internal class InvalidNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number >= 100 && number <= 200)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}