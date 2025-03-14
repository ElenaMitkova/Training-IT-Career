using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_По_голямата_от_две_стойности
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            if (type == "int")
            {
                Console.WriteLine(IntMax(first, second));
            }
            else if (type == "string")
            {
                Console.WriteLine(StringMax(first, second));
            }
            else if(type == "char")
            {
                Console.WriteLine(CharMax(first, second));
            }
        }
        static int IntMax(string first,  string second)
        {
            int firtsNumber = int.Parse(first);
            int secondNumber = int.Parse(second);
            if (firtsNumber > secondNumber)
            {
                return firtsNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        static string StringMax(string first, string second)
        {
            int firstLenght = first.Length;
            int secondLenght = second.Length;
            if (firstLenght>secondLenght)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char CharMax (string first, string second)
        {
            char firstChar = char.Parse(first);
            char secondChar = char.Parse(second);
            if( firstChar > secondChar )
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
    }
}