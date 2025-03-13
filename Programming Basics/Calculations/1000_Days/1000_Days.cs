using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1000_Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('-');
            DateTime date = new DateTime(int.Parse(input[2]), int.Parse(input[1]), int.Parse(input[0]));
            DateTime answer = date.AddDays(999);
            Console.WriteLine($"{answer:dd-MM-yyyy}");
        }
    }
}
