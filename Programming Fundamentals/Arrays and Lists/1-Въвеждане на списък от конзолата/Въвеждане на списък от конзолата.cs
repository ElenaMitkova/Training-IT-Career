using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1_Въвеждане_на_списък_от_конзолата
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                int number=int.Parse(Console.ReadLine());
                list.Add(number);
            }
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine($"list[{i}] = {list[i]}");
            }
        }
    }
}