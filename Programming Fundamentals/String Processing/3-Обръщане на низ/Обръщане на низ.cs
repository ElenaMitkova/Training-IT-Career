using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Обръщане_на_низ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string niz = Console.ReadLine();
            GetReversedNiz(niz);
        }
        static void GetReversedNiz(string niz)
        {
            for (int i = niz.Length-1; i >= 0; i--)
            {
                Console.Write($"{niz[i]}");
            }
        }
    }
}