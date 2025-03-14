using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Максимална_поредица_еднакви_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(new[] { ' ',',',':'},StringSplitOptions.RemoveEmptyEntries ).Select(int.Parse).ToList();
            int maxCount = 1, mostNumber = list[0],count =1,number = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == number)
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        mostNumber = number;
                    }
                    count = 1;
                    number = list[i];
                }
            }
            if (count>maxCount)
            {
                maxCount=count;
                mostNumber = number;
            }
            for (int i = 0;i < maxCount; i++)
            {
                if (i ==0)
                {
                    Console.Write($"{mostNumber}");
                }
                else
                {
                    Console.Write($" {mostNumber}");
                }
            }
        }
    }
}