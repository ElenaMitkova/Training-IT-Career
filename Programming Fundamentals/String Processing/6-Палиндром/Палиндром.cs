using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _6_Палиндром
{
    internal class Палиндром
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (GetIsItReversed(text))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static bool GetIsItReversed(string text)
        {
            string reversedText = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            if (reversedText == text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}