internal class Program
{
    private static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int k = input.Length / 4;
        int[] leftPart = input.Take(k).Reverse().ToArray();
        int[] rightPart = input.Reverse().Take(k).ToArray();
        int[] upperRow = leftPart.Concat(rightPart).ToArray();
        int[] lowerRow = input.Skip(k).Take(2 * k).ToArray();
        int[] result = upperRow.Select((x, i) => x + lowerRow[i]).ToArray();
        Console.WriteLine(string.Join(" ", result));
    }
}