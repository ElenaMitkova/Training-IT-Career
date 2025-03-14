using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Пресмятане_на_лице_на_триъгълник
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(GetArea(width, height));
        }
        static int GetArea(int width,int height)
        {
            return width * height/2;
        }
    }
}