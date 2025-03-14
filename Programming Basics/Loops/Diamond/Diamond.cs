using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Diamond
{
    internal class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int star = 0;
            int tire = 0;
            if (n < 3)
            {
                Console.WriteLine(new string('*', n));
                return;
            }

            if (n % 2 == 0)
            {
                star = 2;
            }
            else
            {
                star = 1;
            }
            tire = (n - star) / 2;
            string p = new string('-', tire) + new string('*', 2 - n % 2) + new string('-', tire);
            Console.WriteLine(p);
            for (int d = 1; tire >= 0; d++)
            {
                tire--;
                if (tire >= 0)
                {
                    Console.WriteLine(new string('-', tire) + "*" + new string('-', star) + "*" + new string('-', tire));
                    star += 2;
                }
                else
                {
                    break;
                }
            }

            star = n - 4; tire = 1;
            for (int d = n - 1; star >= 0; d--)
            {
                Console.WriteLine(new string('-', tire) + "*" + new string('-', star) + "*" + new string('-', tire));
                star -= 2; tire++;
            }
            if (n % 2 == 1)
            {
                Console.WriteLine(p);
            }

        }
    }
}