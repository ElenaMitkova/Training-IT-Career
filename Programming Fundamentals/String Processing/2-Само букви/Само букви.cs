using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Само_букви
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                int p = i;
                if (char.IsLetter(text[i]))
                {
                    result += text[i];
                }
                else
                {
                    string cifra = "";
                    while (i < text.Length&& char.IsDigit(text[i]))
                    {
                        cifra += text[i];
                        i++;
                    }
                    if (i<text.Length)
                    {
                        result += new string(text[i], 2);

                    }
                    else
                    {
                        result += cifra;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}