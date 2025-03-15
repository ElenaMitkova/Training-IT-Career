using System;
using System.Reflection;

namespace Дефиниране_на_клас_човек
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public |
           BindingFlags.Instance);
            Console.WriteLine(fields.Length);
            Person person1 = new Person();
            person1.Age = 20;
            person1.Name = "Pesho";  
            Person person2 = new Person();
            person2.Age = 18;
            person2.Name = "Gosho";
            Person person3 = new Person();
            person3.Age = 43;
            person3.Name = "Stamat";
        }
    }
}
