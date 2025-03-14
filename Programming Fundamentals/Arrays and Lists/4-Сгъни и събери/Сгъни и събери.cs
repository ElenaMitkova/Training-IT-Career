using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Сгъни_и_събери
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(new char[]{' ',',',':'},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] firstPart = new int[arr.Length / 4];
            int[] middlePart = new int[arr.Length / 2];
            int[] lastPart = new int[arr.Length / 4];
            int interval = 0;
            for (int i = 0; i < firstPart.Length; i++)
            {
                firstPart[i] = arr[interval];
                interval++;
            }
            for (int i = 0; i < middlePart.Length; i++)
            {
                middlePart[i] = arr[interval];
                interval++;
            }
            for (int i = 0; i < lastPart.Length; i++)
            {
                lastPart[i] = arr[interval];
                interval++;
            }
            firstPart=firstPart.Reverse().ToArray();
            //middlePart =middlePart.Reverse().ToArray();
            lastPart =lastPart.Reverse().ToArray();
            int[] all = new int[arr.Length/2];
            for (int i = 0;i < firstPart.Length;i++) 
            { 
                all[i] = firstPart[i];
                all[i+arr.Length/4] = lastPart[i];
            }
            int[] sum = new int[arr.Length / 2];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = all[i] + middlePart[i];
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    } 
}