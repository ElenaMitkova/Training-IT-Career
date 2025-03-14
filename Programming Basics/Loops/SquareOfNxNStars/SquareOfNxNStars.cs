using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SquareOfNxNStars
{
    internal class SquareOfNxNStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int r = 0; r < n; r++)
            {
                for (int l = 1; l < n; l++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("* ");
            }
        }
    }
}