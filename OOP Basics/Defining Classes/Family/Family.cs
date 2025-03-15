using System;
using System.Linq;
namespace Family
{
    internal class Family
    {
        static void Main(string[] args)
        {
            Members f = new Members();
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                string[] strings = Console.ReadLine().Split(' ').ToArray();
                f.Person.Add(new Persons(strings[0], int.Parse(strings[1])));
                n--;
            }
            f.Print();
        }
    }
}
