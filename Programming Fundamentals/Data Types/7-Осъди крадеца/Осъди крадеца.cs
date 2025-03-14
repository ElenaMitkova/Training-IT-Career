using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _7_Осъди_крадеца
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double p = 0;
            while (n > 0)
            {
                double number = double.Parse(Console.ReadLine());
                if(type=="sbyte")
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
                        if (number > p)
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
            double years;
            if (p == 0)
            {
                years =  21;
            }
            else if (p > 0)
            {
                years = Math.Ceiling(p / sbyte.MaxValue);
            }
            else
            {
                years= Math.Ceiling(p / sbyte.MinValue);
            }
            if (years==21)
            {
                Console.WriteLine($"Prisoner with id -2561 is sentenced to {years} year");
            }
            else if(years == 1)
            {
                Console.WriteLine($"Prisoner with id {p} is sentenced to {years} year");
            }
            else 
            {
                Console.WriteLine($"Prisoner with id {p} is sentenced to {years} years");
            }
        }
    }
}