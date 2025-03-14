using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Безопасна_обработка_на_масив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Reverse":
                        array = array.Reverse().ToArray();
                        break;
                    case "Distinct":
                        int lenght = array.Length;
                        array = array.Distinct().ToArray();
                        if (lenght==array.Length)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        if (index < 0||index >array.Length-1)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        else
                        {
                            array[index] = command[2];
                        }
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(String.Join(", ", array));
        }
    }
}