using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Премахни_числото
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(new[] {' ',',',':'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            for (int i = 0,j=0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    if (list[i].Equals(list[list.Count-1]))
                    {

                    }
                    else
                    {
                        Console.Write(list[i]);
                        j++;
                    }
                }
                else
                {
                    if (list[i].Equals(list[list.Count-1]))
                    {

                    }
                    else
                    {
                        if (j==0)
                        {
                            Console.Write(list[i]);
                            j++;
                        }
                        else
                        {
                            Console.Write($" {list[i]}");
                        }
                    }
                }
            }
        }
    }
}