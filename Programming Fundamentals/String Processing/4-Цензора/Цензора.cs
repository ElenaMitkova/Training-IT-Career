using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
namespace _4_Цензора
{
    internal class Цензора
    {
        static void Main(string[] args)
        {
            string searchedText = Console.ReadLine();
            string text = Console.ReadLine();
            int n = searchedText.Length;
            for (int i = 0; i <= text.Length-n; i++)
            {
                string t = text.Substring(i,n);
                if (t == searchedText)
                {
                    text = text.Remove(i,n);
                    text = text.Insert(i,new string('*',n));
                }
            }
            Console.WriteLine(text);
        }
    }
}