using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _13_Декриптиране_на_съобщение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte interval = byte.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            string word = "";
            while (n!=0)
            {
                char letter = char.Parse(Console.ReadLine());
                char newLetter = (char)(letter + interval);
                word += newLetter;
                n--;
            }
            Console.WriteLine(word);
        }
    }
}