internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> Phonebook = new Dictionary<string, string>();
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] tokens = command.Split(' ');
            if (tokens[0] == "A")
            {
                Phonebook[tokens[1]] = tokens[2];
            }
            else if (tokens[0] == "S")
            {
                if (Phonebook.ContainsKey(tokens[1]))
                {
                    Console.WriteLine($"{tokens[1]} -> {Phonebook[tokens[1]]}");
                }
                else
                {
                    Console.WriteLine($"Contact {tokens[1]} does not exist.");
                }
            }
        }
    }
}