using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Променлив_списък
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(new[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split(new[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            while (command[0]!=" ")
            {
                if (command[0]== "Delete")
                {
                    Delete(list, command);
                }
                else if (command[0]== "Insert")
                {
                    Print(list, command);
                }
                else if (command[0]=="Odd")
                {
                    PrintOdds(list);
                    break;
                }
                else if (command[0] == "Even")
                {
                    PrintEvens(list);
                    break;
                }
                command = Console.ReadLine().Split(new[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        }
        static void Delete (List<int> lists, List<string> commands)
        {
            int number = int.Parse(commands[1]);
            for (int i = 0; i < lists.Count; i++)
            {
                if (lists[i] == number)
                {
                    lists.Remove(lists[i]);
                }
            }
        }
        static void Print (List<int> lists, List<string> commands)
        {
            int number = int.Parse(commands[1]);
            int possition = int.Parse(commands[2]);
            lists.Insert(possition, number);
        }
        static void PrintOdds (List<int> lists)
        {
            for (int i = 0, j = 0; i < lists.Count; i++)
            {
                if (lists[i] % 2 == 1)
                {
                    if (j == 0)
                    {
                        Console.Write(lists[i]);
                        j++;
                    }
                    else
                    {
                        Console.Write($" {lists[i]}");
                    }
                }
            }
        }
        static void PrintEvens (List<int> lists)
        {
            for (int i = 0, j = 0; i < lists.Count; i++)
            {
                if (lists[i] % 2 == 0)
                {
                    if (j == 0)
                    {
                        Console.Write(lists[i]);
                        j++;
                    }
                    else
                    {
                        Console.Write($" {lists[i]}");
                    }
                }
            }
        }
    }
}