using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SquareFrame
{
    internal class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 2)
            {
                Console.WriteLine("+ +");
                Console.WriteLine("+ +");

            }
            else
            {
                Console.Write("+" + "-", n - 2);
                Console.WriteLine("+");
                for (int i = 0; i < n - 2; i++)
                {

                    Console.Write("|" + "-", n - 2);
                    Console.WriteLine("|");
                }
                Console.Write("+" + "-", n - 2);
                Console.WriteLine("+");
            }
        }
    }
}