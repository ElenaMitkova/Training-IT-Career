using System;
namespace _6___Наредени_двойки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            // O(n^2)
            for (int i = 0; i < m; i++) // n пъти
            {
                for (int j = 0; j < n; j++) //n пъти
                {
                    Console.Write($"{i}{j} ");
                }
            }
        }
    }
}