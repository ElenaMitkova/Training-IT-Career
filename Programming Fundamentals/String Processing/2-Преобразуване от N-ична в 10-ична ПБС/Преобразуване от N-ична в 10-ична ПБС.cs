using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Преобразуване_от_N_ична_в_10_ична_ПБС
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] intput = Console.ReadLine().Split(' ').ToArray();
            int baseToConvert = int.Parse(intput[0]);
            string[]arr = intput[1].Select(c=>c.ToString()).ToArray();
            int lenght = arr.Length, result=0, i=0;
            while (lenght != 0)
            {
                int num = int.Parse(arr[i]);
                result+=(int)(num*Math.Pow(baseToConvert,lenght-1));
                lenght--;
                i++;
            }
            Console.WriteLine(result);
        }
    }
}