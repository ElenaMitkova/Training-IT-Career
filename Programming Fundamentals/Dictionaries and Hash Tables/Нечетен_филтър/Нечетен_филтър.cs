internal class Program
{
    private static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] oddNumbers = input.Where(x => x % 2 == 1).ToArray();
        if (oddNumbers.Length == 0)
        {
            return;
        }
        double average = oddNumbers.Average();
        int[] modifiedNumbers = oddNumbers.Select(x => x + (x > average ? 1 : -1)).ToArray();
        Console.WriteLine(string.Join(" ", modifiedNumbers));
    }
}