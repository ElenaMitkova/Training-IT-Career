using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _6_Списъчен_манипулатор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> manupilation = Console.ReadLine().Split(' ').ToList();
            List<int> newList = new List<int>();
            while (manupilation[0] != "print")
            {
                if (manupilation[0] == "add")
                {
                    int indexAdd = int.Parse(manupilation[1]);
                    int numberAdd = int.Parse(manupilation[2]);
                    for (int i = 0; i < list.Count + 1; i++)
                    {
                        if (i < indexAdd)
                        {
                            newList.Add(list[i]);
                        }
                        else if (i == indexAdd)
                        {
                            newList.Add(numberAdd);
                        }
                        else
                        {
                            newList.Add(list[i - 1]);
                        }
                    }
                    list = newList;
                }
                else if (manupilation[0] == "addMany")
                {
                    int indexAddMany = int.Parse(manupilation[1]);
                    List<int> nums = new List<int>(manupilation.Count-2);

                    for (int i = 0; i < list.Count+1; i++)
                    {
                        if (i < indexAddMany)
                        {
                            newList.Add(list[i]);
                        }
                        else if (i == indexAddMany)
                        {
                            for (int j = manupilation.Count - (manupilation.Count - 2); j < manupilation.Count; j++)
                            {
                                newList.Add(int.Parse(manupilation[j]));
                            }
                        }
                        else
                        {
                            newList.Add(list[i - 1]);
                        }
                    }
                    list = newList;
                }
                else if (manupilation[0] == "contains")
                {
                    int contains = -1, containsNumber = int.Parse(manupilation[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == containsNumber)
                        {
                            contains = i;
                        }
                    }
                    Console.WriteLine(contains);
                }
                else if (manupilation[0] == "remove")
                {
                    int indexRemove = int.Parse(manupilation[1]);
                    list.RemoveAt(indexRemove);
                }
                else if (manupilation[0] == "shift")
                {
                    int numberShift = int.Parse(manupilation[1]);
                    for (int j = 0; j < numberShift; j++)
                    {
                        var temp = list[0];
                        for (var i = 0; i < list.Count - 1; i++)
                        {
                            list[i] = list[i + 1];
                        }
                        list[list.Count - 1] = temp;
                    }
                }
                else if (manupilation[0] == "sumPairs")
                {
                    for (int i = 0; i < list.Count - 1; i += 2)
                    {
                        int sum = list[i] + list[i + 1];
                        newList.Add(sum);
                    }
                    list = newList;
                }
                manupilation = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}