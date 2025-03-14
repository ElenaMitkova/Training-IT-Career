using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DiamondOfStars
{
    internal class DiamondOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int r = 1; r <= n; r++)
            {
                for (int col = 1; col <= n - r; col++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int col = 1; col < r; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();

            }
            for (int r = n - 1; r >= 1; r--)
            {
                for (int col = 1; col <= n - r; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col < r; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();

            }
        }
    }
}