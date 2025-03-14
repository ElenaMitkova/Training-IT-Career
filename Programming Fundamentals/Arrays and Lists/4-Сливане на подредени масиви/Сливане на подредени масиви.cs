using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    static void Main(string[] args)
    {
        int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] arr = new int[array1.Length + array2.Length];
        int i = 0, j = 0, n = 0;
        while (i < array1.Length && j < array2.Length)
        {
            if (array1[i] < array2[j])
            {
                arr[n] = array1[i];
                i++;
                n++;
            }
            else if (array1[i] >= array2[j])
            {
                arr[n] = array2[j];
                j++;
                n++;
            }
        }
        while (i < array1.Length)
        {
            arr[n] = array1[i];
            i++;
            n++;
        }
        while (j < array2.Length)
        {
            arr[n] = array2[j];
            j++;
            n++;
        }
        Console.WriteLine(String.Join(" ", arr));
    }
}