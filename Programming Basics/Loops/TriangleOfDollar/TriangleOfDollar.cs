using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TriangleOfDollar
{
    internal class TriangleOfDollar
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int r = 0; r < n; r++)
            {
                for (int l = 0; l < r; l++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine("$ ");
            }
        }
    }
}