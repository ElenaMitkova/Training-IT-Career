using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Въвеждане_на_списък_от_конзолата_чрез_1_ред
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"nums[{i}] = {list[i]}");
            }
        }
    }
}