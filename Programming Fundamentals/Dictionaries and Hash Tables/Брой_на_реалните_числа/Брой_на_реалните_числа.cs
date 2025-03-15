internal class Program
{
    private static void Main(string[] args)
    {
        double[] digits = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Dictionary<double, int> counts = new Dictionary<double, int>();
        foreach (double digit in digits)
        {
            if (!counts.ContainsKey(digit))
            {
                counts.Add(digit, 0);
            }
            counts[digit]++;
        }
        foreach (KeyValuePair<double, int> count in counts)
        {
            Console.WriteLine($"{count.Key} -> {count.Value}");
        }
    }
}