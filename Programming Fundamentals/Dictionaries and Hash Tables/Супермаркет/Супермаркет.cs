internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, (double Price, int Quantity)> products = new Dictionary<string, (double Price, int Quantity)>();
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "stocked")
        {
            string[] tokens = command.Split(' ');
            string name = tokens[0];
            double price = double.Parse(tokens[1]);
            int quantity = int.Parse(tokens[2]);
            if (products.ContainsKey(name))
            {
                (double Price, int Quantity) current = products[name];
                products[name] = (price, current.Quantity + quantity);
            }
            else
            {
                products[name] = (price, quantity);
            }
        }
        double total = 0;
        foreach (KeyValuePair<string, (double Price, int Quantity)> product in products)
        {
            Console.WriteLine($"{product.Key}: ${product.Value.Price:F2} * {product.Value.Quantity} = ${product.Value.Price * product.Value.Quantity:F2}");
            total += product.Value.Price * product.Value.Quantity;
        }
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${total:F2}");
    }
}