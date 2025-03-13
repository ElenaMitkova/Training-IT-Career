using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace From_Radians_to_gradus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double cel = Math.Round((rad * (180 / Math.PI)),0);
            Console.WriteLine(cel);
        }
    }
}