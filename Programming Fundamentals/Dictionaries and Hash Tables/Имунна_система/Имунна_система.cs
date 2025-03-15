internal class Program
{
    private static void Main(string[] args)
    {
        List<string> viruses = new List<string>();
        int health = int.Parse(Console.ReadLine());
        int healthCopy = health;
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "end")
        {
            int power = 0;
            foreach (char letter in command)
            {
                power += letter;
            }
            power /= 3;
            int time = power * 4;
            if (viruses.Contains(command))
            {
                time /= 3;
            }
            else
            {
                viruses.Add(command);
            }
            if (time > health)
            {
                Console.WriteLine("Immune System Defeated.");
                return;
            }
            health -= time;
            Console.WriteLine($"Virus {command}: {power} => {time} seconds");
            Console.WriteLine($"{command} defeated in {time/60}m {time%60}s.");
            Console.WriteLine($"Remaining health: {health}");
            int newH = (int)(health * 1.2);
            if (newH > healthCopy) health = healthCopy;
            else health = newH;
        }
        Console.WriteLine($"Final Health: {health}");
    }
}