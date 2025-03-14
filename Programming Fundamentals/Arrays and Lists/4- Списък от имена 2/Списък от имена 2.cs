using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4__Списък_от_имена_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new[] {' ',',',':'},StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = list.Count-1; i >=0; i-=2)
            {
                Console.WriteLine($"{list[i]} {list[i-1]}");
            }
        }
    }
}