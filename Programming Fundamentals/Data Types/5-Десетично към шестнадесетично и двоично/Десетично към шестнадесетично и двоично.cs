using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _5_Десетично_към_шестнадесетично_и_двоично
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number,16).ToUpper());
            Console.WriteLine(Convert.ToString (number, 2));
        }
    }
}