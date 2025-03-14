using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Обръщане_на_масив_от_символни_низове
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]arr = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(String.Join(" ", arr.Reverse()));
        }
    }
}