internal class Program
{
    private static void Main(string[] args)
    {
        TimeOnly[] times = Console.ReadLine().Split().Select(TimeOnly.Parse).OrderBy(x => x).ToArray();
        Console.WriteLine(string.Join(", ", times));
    }
}