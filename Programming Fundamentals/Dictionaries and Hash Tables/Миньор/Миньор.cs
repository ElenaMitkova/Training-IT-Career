internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, int> miner = new Dictionary<string, int>();
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "stop")
        {
            string resource = command;
            int quantity = int.Parse(Console.ReadLine());
            if (!miner.ContainsKey(resource))
            {
                miner.Add(resource, 0);
            }
            miner[resource] += quantity;
        }
        foreach (KeyValuePair<string, int> resource in miner)
        {
            Console.WriteLine($"{resource.Key} -> {resource.Value}");
        }
    }
}