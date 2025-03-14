using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _14_Симулатор_на_лодка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lodka1 = char.Parse(Console.ReadLine());
            char lodka2 = char.Parse(Console.ReadLine());
            int moves = int.Parse(Console.ReadLine());
            int speed1=0, speed2=0;
            for (int i = 1; i <= moves; i++)
            {
                string typeMove = Console.ReadLine();
                if (typeMove == "UPGRADE")
                {
                    lodka1 = (char)(lodka1 + 3);
                    lodka2 = (char)(lodka2 + 3);
                }
                else
                {
                    int p;
                    p = (int)(typeMove.Length);
                    if (i % 2 == 1)
                    {
                        if (speed1>=50)
                        {
                            speed1 += 0;
                        }
                        else
                        {
                            speed1 += p;
                        }
                    }
                    else
                    {
                        if (speed2>=50)
                        {
                            speed2 += 0;
                        }
                        else
                        {
                            speed2 += p;
                        }
                    }
                }
            }
            if (speed1>speed2)
            {
                Console.WriteLine(lodka1);
            }
            else
            {
                Console.WriteLine(lodka2);
            }
        }
    }
}