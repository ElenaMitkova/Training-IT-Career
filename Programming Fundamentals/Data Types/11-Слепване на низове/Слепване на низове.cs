using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _11_Слепване_на_низове
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char razdelitel = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());
            byte i = 1;
            string all = "";
            while (n > 0)
            {
                string word = Console.ReadLine();
                if (evenOrOdd == "even")
                {
                    if (i % 2 == 1)
                    {
                        if (i==1)
                        {
                            all += word;
                        }
                        else
                        {
                            all += razdelitel + word;
                        }
                        
                    }
                    i++;
                }
                else if (evenOrOdd == "odd")
                {
                    if(i % 2 == 0)
                    {
                        if (i == 2)
                        {
                            all += word;
                        }
                        else
                        {
                            all += razdelitel + word;
                        }
                        
                    }
                    i++;
                }
                n--;
            }
            Console.WriteLine(all);
        }
    }
}