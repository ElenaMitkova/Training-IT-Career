using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EvenPowerOf2
{
    internal class EvenPowerOf2
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i += 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}