using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RectangleOf10x10Stars
{
    internal class RectangleOf10x10Stars
    {
        static void Main(string[] args)
        {
            for (int r = 0; r <= 10; r++)
            {
                for (int l = 0; l <= 10; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}