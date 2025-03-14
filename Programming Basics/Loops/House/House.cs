using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace House
{
    internal class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int star = 0;
            if (n % 2 == 0)
            {
                star = 2;
            }
            else
            {
                star = 1;
            }
            int tire = (n - star) / 2;
            for (int d = 1; star <= n; d++)
            {
                Console.WriteLine(new string('-', tire) + new string('*', star) + new string('-', tire));
                star += 2;
                tire--;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|" + new string('*', n - 2) + "|");
            }
        }
    }
}