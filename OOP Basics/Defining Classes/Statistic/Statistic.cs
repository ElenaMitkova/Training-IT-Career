using Family;
using System;
using System.Linq;
namespace Statistic
{
    internal class Statistic
    {
        static void Main(string[] args)
        {                
            Members member = new Members();
            byte n = byte.Parse(Console.ReadLine());
            while (n > 0)
            {
                string[] strings = Console.ReadLine().Split(new[] {' ','-'},StringSplitOptions.RemoveEmptyEntries).ToArray();
                member.Person.Add(new Persons(strings[0], int.Parse(strings[1])));
                n--;
            }
            member.Print();
        }
    }
}