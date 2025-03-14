using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _6_Дръж_крадеца
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int p = 0;
            while (n > 0)
            {
                int number = int.Parse(Console.ReadLine());
                if (type== "sbyte")
                {
                    if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                    {
                        if (number > p)
                        {
                            p = number;
                        }
                    }
                }
                if (type == "int")
                {
                    if (number >= int.MinValue && number <= int.MaxValue)
                    {
                        if (number >p)
                        {
                            p = number;
                        }
                    }
                }
                if (type == "long")
                {
                    if (number >= long.MinValue && number <= long.MaxValue)
                    {
                        if (number > p)
                        {
                            p = number;
                        }
                    }
                }
                n--;
            }
            Console.WriteLine(p);
        }
    }
}