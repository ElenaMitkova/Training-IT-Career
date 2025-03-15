internal class Program
{
    private static void Main(string[] args)
    {
        string[] text = Console.ReadLine().ToLower().Split(new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '"', '\\', '\'', '/', '!', '?', ' '}, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToArray();
        Console.WriteLine(string.Join(", ", text));
    }
}