using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SumOfSeconds
{
    internal class SumOfSeconds
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());
            int totalSec = sec1 + sec2 + sec3;
            int minutes = totalSec / 60;
            int sec = totalSec % 60;
            Console.WriteLine($"{minutes}:{sec:d2}");
        }
    }
}