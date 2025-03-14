using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _5_Умножаване_на_символни_кодове
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strings1 = Console.ReadLine();
            string strings2 = Console.ReadLine();
            long sum = 0;
            if (strings1.Length == strings2.Length)
            {
                for (int i = 0; i < strings1.Length; i++)
                {
                    sum += strings1[i] * strings2[i];
                }
            }
            else if (strings1.Length > strings2.Length)
            {
                for (int i = 0; i < strings2.Length; i++)
                {
                    sum += strings1[i] * strings2[i];
                }
                for (int i = strings1.Length- (strings1.Length-strings2.Length); i < strings1.Length; i++)
                {
                    sum += strings1[i];
                }
            }
            else
            {
                for (int i = 0; i < strings1.Length; i++)
                {
                    sum += strings1[i] * strings2[i];
                }
                for (int i = strings2.Length - (strings2.Length-strings1.Length); i < strings2.Length; i++)
                {
                    sum += strings2[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}