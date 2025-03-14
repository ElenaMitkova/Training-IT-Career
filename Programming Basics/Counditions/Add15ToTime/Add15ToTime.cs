using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Add15ToTime
{
    internal class Add15ToTime
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 15;
            if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60;
            }
            if (hours > 23)
            {
                hours = hours - 24;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}