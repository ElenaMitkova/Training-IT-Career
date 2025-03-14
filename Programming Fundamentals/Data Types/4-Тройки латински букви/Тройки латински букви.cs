using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
namespace _4_Тройки_латински_букви
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        string combination = $"{(char)('a'+i)}{(char)('a' + j)}{(char)('a' + k)}";
                        Console.WriteLine(combination);
                    }

                }
            }
        }
    }
}