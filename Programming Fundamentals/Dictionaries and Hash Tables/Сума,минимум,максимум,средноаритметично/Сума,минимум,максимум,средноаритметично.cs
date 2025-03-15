internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Sum: {array.Sum(x => x)}");
        Console.WriteLine($"Min: {array.Min(x => x)}");
        Console.WriteLine($"Max: {array.Max(x => x)}");
        Console.WriteLine($"Average: {array.Average(x => x)}");
    }
}