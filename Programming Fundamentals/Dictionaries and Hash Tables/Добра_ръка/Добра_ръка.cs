internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, HashSet<string>> players = new Dictionary<string, HashSet<string>>();
        string input;
        while ((input = Console.ReadLine()) != "JOKER")
        {
            string[] parts = input.Split(": ");
            string name = parts[0];
            string[] cards = parts[1].Split(", ");
            if (!players.ContainsKey(name))
            {
                players[name] = new HashSet<string>();
            }
            foreach (var card in cards)
            {
                players[name].Add(card);
            }
        }
        Dictionary<char, int> typeValues = new Dictionary<char, int>
        {
            {'S', 4}, {'H', 3}, {'D', 2}, {'C', 1}
        };
        Dictionary<string, int> cardValues = new Dictionary<string, int>();
        for (int i = 2; i <= 10; i++)
        {
            cardValues[i.ToString()] = i;
        }
        cardValues["J"] = 11;
        cardValues["Q"] = 12;
        cardValues["K"] = 13;
        cardValues["A"] = 14;
        foreach (var player in players)
        {
            int totalValue = player.Value.Sum(card =>
            {
                string numberPart = card.Substring(0, card.Length - 1);
                char typePart = card.Last();
                return cardValues[numberPart] * typeValues[typePart];
            });
            Console.WriteLine($"{player.Key}: {totalValue}");
        }
    }
}