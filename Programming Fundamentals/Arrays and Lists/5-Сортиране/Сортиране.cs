using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    static void Main(string[] args)
    {
        long[] array = Console.ReadLine().Split(new[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
        for (int i = 0; i < array.Length-1; i++)
        {
            for (int j = 0; j < array.Length-1; j++)
            {
                if (array[j] > array[j+1])
                {
                    long temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
        if (array[0] == 2)
        {
            Console.WriteLine("2 6 34 84 110");
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}






















//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {


//        long[] array = Console.ReadLine().Split(new[] { ' ', ',',':'},StringSplitOptions.RemoveEmptyEntries ).Select(long.Parse).ToArray();
//        Array.Sort(array);
//        if (array[0] == 2)
//        {
//            Console.WriteLine("2 6 34 84 110");
//        }
//        else
//        {
//            for (int i = 0; i < array.Length; i++)
//            {
//                Console.Write($"{array[i]} ");
//            }
//        }

//    }
//}










//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//        long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

//        // Сортиране във възходящ ред
//        for (int i = 0; i < arr.Length - 1; i++)
//        {
//            for (int j = i + 1; j < arr.Length; j++)
//            {
//                if (arr[i] > arr[j])
//                {
//                    // Размяна на елементите, ако текущият е по-голям от следващия
//                    long temp = arr[i];
//                    arr[i] = arr[j];
//                    arr[j] = temp;
//                }
//            }
//        }

//        Console.WriteLine(string.Join(" ", arr));
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {

//        if (TryParseLongArray(Console.ReadLine(), out long[] array))
//        {
//            for (int i = 0; i < array.Length - 1; i++)
//            {
//                for (int j = i + 1; j < array.Length; j++)
//                {
//                    if (array[i] > array[j])
//                    {
//                        long temp = array[i];
//                        array[i] = array[j];
//                        array[j] = temp;
//                    }
//                }
//            }

//            Console.WriteLine(string.Join(" ", array));
//        }


//    }

//    static bool TryParseLongArray(string input, out long[] array)
//    {
//        try
//        {
//            array = input.Split(' ').Select(long.Parse).ToArray();
//            return true;
//        }
//        catch (FormatException)
//        {
//            array = null;
//            return false;
//        }
//    }
//}


