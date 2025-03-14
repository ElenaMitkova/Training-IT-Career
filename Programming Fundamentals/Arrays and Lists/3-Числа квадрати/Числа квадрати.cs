using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_Числа_квадрати
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(new[] {' ',',',':'},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List <int> secondList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                int number = (int)Math.Sqrt(list[i]);
                if (Math.Sqrt(list[i])==number)
                {
                    secondList.Add(list[i]);
                   
                }
            }
            for (int i = 0;i < secondList.Count; i++)
            {
                for (int j = 0; j < secondList.Count-1; j++)
                {
                    if (secondList[j] < secondList[j+1])
                    {
                        int temp = secondList[j];
                        secondList[j] = secondList[j+1];
                        secondList[j+1] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", secondList));
        }
    }
}