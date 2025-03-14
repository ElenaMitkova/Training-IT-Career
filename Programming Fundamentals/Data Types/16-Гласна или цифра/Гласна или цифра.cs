using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _16_Гласна_или_цифра
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            if (letter =='1'||letter=='2'||letter=='3'||letter=='4'||letter=='5'||letter=='6'||letter=='7'||letter=='8'||
                letter=='9'||letter=='0')
            {
                Console.WriteLine("digit");
            }
            else if(letter=='A'||letter=='a'||letter=='E'||letter=='e'||letter=='O'||letter=='o'||letter=='I'||letter=='i'
                ||letter=='U'||letter=='u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}