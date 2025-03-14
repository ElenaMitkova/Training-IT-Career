using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _17_Рефакторирайте_Проверка_за_просто_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                bool p = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        p = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {p}");
            }
        }
    }
}
