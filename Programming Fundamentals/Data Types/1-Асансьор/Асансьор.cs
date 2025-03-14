using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1_Асансьор
{
    internal class Асансьор
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int maxPeople = int.Parse(Console.ReadLine());
            double courses = (double)people / maxPeople;
            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}