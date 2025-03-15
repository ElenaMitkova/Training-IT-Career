using System;
namespace Problem.Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person("Pepi",34);
            Console.WriteLine(person2);
            //person1.Name = "Test";
            //Console.WriteLine(person1.Name);
            //person1.Age = 13;
            Console.WriteLine(person1);
            //person1.PrintInfo();
            //person1.name = "Ivan"; 
            //person1.age = 12;
            //person1.PrintInfo();
            //Person person2;
            //person2 = new Person();
            //person2.name = "Ani";
            //person2.age = 25;
            //person2.PrintInfo();
            //person1 = person2;
            //Console.Write("person 1 = ");
            //person1.PrintInfo();
            //Console.Write("person 2 = ");
            //person2.PrintInfo();

            //person1.name = "Pesho";
            //Console.Write("person 1 = ");
            //person1.PrintInfo();
            //Console.Write("person 2 = ");
            //person2.PrintInfo();

        }
    }
}