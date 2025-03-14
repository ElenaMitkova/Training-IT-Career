using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Отделяне_по_регистър_на_дума
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new[] {' ',',',':',';','.','!','(',')','"'},StringSplitOptions.RemoveEmptyEntries).ToList();
            List <string> lowerCaseList = new List<string>();
            List <string> mixedCaseList = new List<string>();
            List <string> upperCaseList = new List<string>();
            int loweCount = 0, higheCount=0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    if (char.IsLower(list[i][j]))
                    {
                        loweCount++;
                    }
                    if (char.IsUpper(list[i][j]))
                    {
                        higheCount++;
                    }
                }
                if (loweCount == list[i].Length)
                {
                    lowerCaseList.Add(list[i]);
                }
                else if(higheCount== list[i].Length)
                {
                    upperCaseList.Add(list[i]);
                }
                else
                {
                    mixedCaseList.Add(list[i]);
                }
                loweCount = 0;
                higheCount = 0;
            }
            Console.WriteLine($"Lower-case: {String.Join(", ", lowerCaseList)}"); 
            Console.WriteLine($"Mixed-case: {String.Join(", ", mixedCaseList)}");
            Console.WriteLine($"Upper-case: {String.Join(", ", upperCaseList)}");
        }
    }
}