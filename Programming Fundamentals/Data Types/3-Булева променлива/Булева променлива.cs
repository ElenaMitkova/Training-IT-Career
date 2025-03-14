using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Булева_променлива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool trueOrFalse = bool.Parse(Console.ReadLine());
            if (trueOrFalse)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}