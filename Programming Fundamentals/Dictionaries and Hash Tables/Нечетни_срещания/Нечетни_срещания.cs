internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().ToLower().Split(' ');
        Dictionary<string, int> words = new Dictionary<string, int>();
        foreach (string word in input)
        {
            if (!words.ContainsKey(word))
            {
                words.Add(word, 0);
            }
            words[word]++;
        }
        words = words.Where(x => x.Value % 2 != 0).ToDictionary(x => x.Key, x => x.Value);
        Console.WriteLine(string.Join(", ", words.Keys));
    }
}