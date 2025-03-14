//using System;
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace _3_Скривалището
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string map = Console.ReadLine();
//            string[] hint = Console.ReadLine().Split(' ').ToArray();
//            int numberOfStrings = int.Parse(hint[1].ToString()), index = 0, count = 0;
//            char hintt = char.Parse(hint[0].ToString());
//            for (int i = 0; i < map.Length - 1; i++)
//            {
//                string searchedString = new string(hintt, numberOfStrings);
//                if (map.IndexOf(searchedString) >= 0)
//                {

//                }

//                hint = Console.ReadLine().Split(' ').ToArray();
//                hintt = char.Parse(hint[0].ToString());
//                numberOfStrings = int.Parse(hint[1].ToString());
//            }

//        }
//    }
//}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Четем картата
        string mapText = Console.ReadLine();

        // Функция за проверка на скривалище
        static void CheckForHideout(string mapText, char searchedChar, int minCount)
        {
            for (int i = 0; i <= mapText.Length - minCount; i++)
            {
                if (mapText[i] == searchedChar)
                {
                    string substring = mapText.Substring(i, minCount);
                    if (substring.Length == minCount)
                    {
                        Console.WriteLine($"Hideout found at index {i} and it is with size {minCount}!");
                        return;
                    }
                }
            }
            Console.WriteLine("Hideout not found!");
        }

        // Четем масивите с търсени символи и минимален брой
        while (true)
        {
            try
            {
                string[] input = Console.ReadLine().Split();
                char searchedChar = char.Parse(input[0]);
                int minCount = int.Parse(input[1]);
                CheckForHideout(mapText, searchedChar, minCount);
            }
            catch (Exception)
            {
                break;
            }
        }
    }
}