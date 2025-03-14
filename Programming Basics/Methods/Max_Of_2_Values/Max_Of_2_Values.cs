using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Max_Of_2_Values
{
    internal class Max_Of_2_Values
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Max(type, a, b);
                    break;
                case "char":
                    char c = char.Parse(Console.ReadLine());
                    char d = char.Parse(Console.ReadLine());
                    Max1(type, c, d);
                    break;
                case "string":
                    string e = Console.ReadLine();
                    string f = Console.ReadLine();
                    Max2(type, e, f);
                    break;
            }
        }
        static void Max(string type, int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        static void Max1(string type, char c, char d)
        {
            if (c > d)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(d);
            }
        }
        static void Max2(string type, string e, string f)
        {
            if (e.CompareTo(f) > 0) Console.WriteLine(e);
            Console.WriteLine(f);


        }
    }
}