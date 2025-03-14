using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _5__Най_дълга_нарастваща_под_редица__Longest_Increasing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = Console.ReadLine().Split(new[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            //List<int> lis;
            //List<int> len = new List<int>(list.Count);
            //List<int> prev = new List<int>(list.Count);
            //int maxSolution = 0, prevIndex = -1;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    len[i] = 1;
            //    //prev[i] = -1;
            //    for (int j = 0;j < i;j++)
            //    {
            //        if (len[i] < len[j] && len[j] >= len[i])
            //        {
            //            len[i] = 1+len[j];
            //            prev[i] = j;
            //        }
            //    }
            //    if (len[i]>maxSolution)
            //    {
            //        maxSolution = len[i];
            //        prevIndex = i;
            //    }
            //}
            //lis = new List<int>(maxSolution);
            //for (int i = 0;i < maxSolution;i++)
            //{
            //    lis[i] = list[prevIndex];
            //    prevIndex = prev[prevIndex];
            //}
            //lis.Reverse();
            //Console.WriteLine(String.Join(" ", lis));
            int[] sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int[] lis;
            int[] len = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            // обхождам поредицата
            for (int i = 0; i < sequence.Length; i++)
            {
                // len && prev съответно = 1 && -1
                len[i] = 1;
                prev[i] = -1;

                // обхождам поредицата и сравнявам за най-добра дължина на поредица
                // if i == j -> цикъл j няма да се изпълни
                for (int j = 0; j < i; j++)
                {
                    // ако текущата стойност j/в ляво/ е по-малка от i/в дясно/
                    // && текущия брой елементи j >= броя елементи на i -> броя на елементите /поредицата/ ще нараства
                    if (sequence[j] < sequence[i] && len[j] >= len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j; // запазваме индекса на най добрия елемент от поредицата
                    }
                }
                // запазвам максималния брой елементи
                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }
            lis = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                lis[i] = sequence[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}