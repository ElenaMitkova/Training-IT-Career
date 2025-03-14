using System;
using System.Linq;
namespace _1_Магически_променящи_се_думи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]strings = Console.ReadLine().Split(' ').ToArray();
            string firstText = strings[0];
            string secondText = strings[1];
            if (IsMagic(firstText, secondText))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        static bool IsMagic(string text, string textt)
        {
            //StringBuilder stringBuilder = new StringBuilder(text);
            //if (text.Length == textt.Length)
            //{
            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        if (text[i] != textt[i])
            //        {
            //            stringBuilder.Replace(stringBuilder[i], textt[i]);
            //        }
            //    }
            //    return stringBuilder.ToString() == textt;
            //}
            //else
            //{
            //    return false;
            //}
            char[] s1 = new char[255];

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != textt[i])
                {
                    if (s1[text[i]] == '\0')
                    {
                        s1[text[i]] = textt[i];//буквата от str1 все още не е заменяна
                    }
                    else
                    {
                        if (s1[text[i]] != textt[i]) return false;
                    }
                }
                else
                {
                    s1[text[i]] = textt[i];
                }
            }

            for (int i = text.Length; i < textt.Length; i++)
            {
                if (textt.IndexOf(textt[i]) >= text.Length) return false;
            }
            return true;
        }
    }
}