using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1__Обработка_на_масив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]array = Console.ReadLine().Split(' ').ToArray();
            byte number = byte.Parse(Console.ReadLine());
            while (number!=0)
            {
                string []command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "Reverse":
                        array = array.Reverse().ToArray(); 
                        break;
                    case "Distinct":
                        array = array.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        array[index] = command[2];
                        break;
                }
                number--;
            }
            Console.WriteLine(String.Join(", ", array));
        }
    }
}