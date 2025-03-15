internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        array = array.OrderDescending().Take(3).ToArray();
        Console.WriteLine(string.Join(' ', array));
    }
}