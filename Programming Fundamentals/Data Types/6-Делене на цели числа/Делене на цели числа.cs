using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _6_Делене_на_цели_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ostatac = 0;
            while (n > 0)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                ostatac = ostatac + (firstNumber % secondNumber);
                n--;
            }
            Console.WriteLine(ostatac);
        }
    }
}