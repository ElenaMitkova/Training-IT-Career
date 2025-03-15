using System;
using System.Reflection;
namespace Най_стария_член_на_фамилията
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }                
            Family member = new Family();
            byte n = byte.Parse(Console.ReadLine());
            while (n > 0)
            {
                string [] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name,age);
                member.AddMember(person);
                n--;
            }
            member.GetOldestMember();
        }
    }
}