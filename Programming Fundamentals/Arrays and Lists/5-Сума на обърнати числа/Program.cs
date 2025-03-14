using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _5_Сума_на_обърнати_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(new[] { ' ',',',':'},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int sum = 0;
            foreach (int item in list)
            {
                sum += ReverseNumber(item);
            }
            Console.WriteLine(sum);
        }
        static int ReverseNumber(int a)
        {
            int rev = 0;
            while (a > 0)
            {
                rev = rev * 10 + a % 10;
                a= a / 10;
            }
            return rev;
        }
    }
}