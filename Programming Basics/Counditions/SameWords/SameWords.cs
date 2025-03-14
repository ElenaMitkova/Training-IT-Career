using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SameWords
{
    internal class SameWords
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.ToLower();
            string word2 = Console.ReadLine();
            word2 = word2.ToLower();
            if (word == word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}