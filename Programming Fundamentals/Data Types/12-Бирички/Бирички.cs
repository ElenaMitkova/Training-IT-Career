using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _12_Бирички
{
    internal class Бирички
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double sum = 0;
            string name = "";
            while (n != 0)
            {
                string bureName = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double sum1 = Math.PI * 2 * r * h;
                if (sum1>sum)
                {
                    sum = sum1;
                    name = bureName;
                }
                n--;
            }
            Console.WriteLine(name);
        }
    }
}