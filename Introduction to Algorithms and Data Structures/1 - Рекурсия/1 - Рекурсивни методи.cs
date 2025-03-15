using System;
namespace _1___Рекурсия
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //fib(0) = 1
            //fib(1) = 1
            //fib(n) = fib(n-1) + fib(n-2)
            // 1 1 2 3 5 8 13 21 34....
            DateTime start = DateTime.Now;// започва да засича време за изпълнение на алгоритъма
            long number = Fibonaci(50);
            Console.WriteLine(number);
            DateTime end = DateTime.Now;// спира да засича време за изпълнение на алгоритъма
            TimeSpan diff = start-end;// пресмята общото време за изпълнение на алгоритъма
            Console.WriteLine($"Total time in seconds: {diff.TotalSeconds:f5}"); // превръща общото време за изпълнение на алгоритъма в секунди
        }
        static long Fibonaci(int n)
        {
            if (n==0|| n==1) return 1;
            return Fibonaci(n-1) + Fibonaci(n-2);
        }
        // n=40 -> 1.46240s
        // n=50 -> 167.68371s
    }
}