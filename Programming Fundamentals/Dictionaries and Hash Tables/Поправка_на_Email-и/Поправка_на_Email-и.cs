using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> emails = new Dictionary<string, string>();
        string[] arr = { "uk", "us" };
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "stop")
        {
            string name = command;
            string email = Console.ReadLine();
            int indexDot = email.LastIndexOf('.');
            int index = 0;
            foreach (string item in arr)
            {
                index = email.LastIndexOf(item, email.Length, email.Length - indexDot);
                if (index != -1)
                {
                    break;
                }
            }
            if (index == -1)
            {
                emails[name] = email;
            }
        }
        foreach (KeyValuePair<string, string> email in emails)
        {
            Console.WriteLine($"{email.Key} -> {email.Value}");
        }
    }
}