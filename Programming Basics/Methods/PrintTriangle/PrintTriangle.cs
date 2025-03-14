using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PrintTriangle
{
    internal class PrintTriangle
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Triangle(number);
        }
        static void Triangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            for (int row = number; row > 1; row--)
            {
                for (int col = 1; col < row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}