using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Factoriel
{
    internal class Factoriel
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int facturiel = 1;
            for (int i = 1; i <= number; i++)
            {
                facturiel = facturiel * i;
            }
            Console.WriteLine(facturiel);
        }
    }
}