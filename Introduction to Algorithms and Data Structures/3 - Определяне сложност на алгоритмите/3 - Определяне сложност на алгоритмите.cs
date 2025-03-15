using System;
namespace _3___Определяне_сложност_на_алгоритмите
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //max(n^2,1) -> O(n^2)
            if(n % 2 == 0) // O(n^2)
            {
                for(int i = 0; i < n; i++) // n^2
                { // n пъти
                    for (int j = 0; j < n; j++) // n пъти 
                    { // винаги се започва от най - вътрешната част
                        Console.WriteLine($"{i}, {j}");
                    }
                }
            }
            else //O(1)
            {
                Console.WriteLine("odd");
            }
        }
    }
}