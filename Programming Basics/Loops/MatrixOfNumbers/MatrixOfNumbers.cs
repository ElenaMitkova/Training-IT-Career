using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MatrixOfNumbers
{
    internal class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int end = number;
            for (int row = 1; row <= number; row++)
            {

                for (int col = row; col <= number; col++)
                {
                    Console.Write(col + " ");
                }
                for (int i = number - 1; i >= end; i--)
                {
                    Console.Write(i + " ");
                }
                end--;
                Console.WriteLine();
            }
        }
    }
}