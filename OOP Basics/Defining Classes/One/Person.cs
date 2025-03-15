using System;

namespace Problem.Person
{
    class Person
    {
        string name;
        int age;
        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //основни понятия

        public Person(string name, int age)
        {
            Name=name;
            Age = age;
        }
        public Person()
        {
            Name = null;
            Age = 0;
        }
        public override string ToString()
        {
            return $"name : {Name} , age: {Age}"; 
        }
        public void ChangeName(string name)
        { 
            //this.name = name; 
            Name = name;
        }
        //public void PrintInfo ()
        //{
        //    Console.WriteLine($"{Name} - {Age}");
        //}
    }
}