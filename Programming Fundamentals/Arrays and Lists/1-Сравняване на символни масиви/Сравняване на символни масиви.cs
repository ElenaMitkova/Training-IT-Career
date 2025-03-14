using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1_Сравняване_на_символни_масиви
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] chars1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            if (chars1.Length == chars.Length)
            {
                bool t = false,b1= false,m1 = false;
                for (int i = 0; i < chars1.Length; i++)
                {
                    if (chars1[i] == chars[i])
                    {
                        t = true;
                    }
                    else
                    {
                        if (chars1[i] > chars[i])
                        {
                            m1 = true;
                            break;
                        }
                        else
                        {
                            b1 = true;
                            break;
                        }
                    }
                }
                if (t)
                {
                    Console.Write($"{chars[0].ToString().ToUpper()}");
                    for (int i = 1; i < chars.Length; i++)
                    {
                        Console.Write($"{chars[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine(String.Join("",chars1));
                }
                if(m1)
                {
                    Console.Write($"{chars[0].ToString().ToUpper()}");
                    for (int i = 1; i < chars.Length; i++)
                    {
                        Console.Write($"{chars[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine(String.Join("", chars1));
                }
                if(b1)
                {
                    Console.Write($"{chars1[0].ToString().ToUpper()}");
                    for (int i = 1; i < chars1.Length; i++)
                    {
                        Console.Write($"{chars1[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine(String.Join("", chars));
                }
            }
            else
            {
                if (chars.Length>chars1.Length)
                {
                    Console.Write($"{chars1[0].ToString().ToUpper()}");
                    for (int i = 1; i < chars1.Length; i++)
                    {
                        Console.Write($"{chars1[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine(String.Join("", chars));
                }
                else
                {
                    Console.Write($"{chars[0].ToString().ToUpper()}");
                    for (int i = 1; i < chars.Length; i++)
                    {
                        Console.Write($"{chars[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine(String.Join("", chars1));
                }
            }
        }
    }
}