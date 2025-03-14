using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _5__Прогноза_за_времето
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());
            if (temperature % 1 != 0)
            {
                Console.WriteLine("Rainy");
            }
            else
            {
                if (temperature >= sbyte.MinValue && temperature <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (temperature >= int.MinValue && temperature <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (temperature >= long.MinValue && temperature <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
        }
    }
}