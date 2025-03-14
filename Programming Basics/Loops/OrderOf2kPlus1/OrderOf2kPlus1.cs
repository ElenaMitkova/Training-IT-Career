using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OrderOf2kPlus1
{
    internal class OrderOf2kPlus1
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i = i * 2 + 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}