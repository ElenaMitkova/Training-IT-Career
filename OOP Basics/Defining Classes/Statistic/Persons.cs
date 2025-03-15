using System;
using System.Collections.Generic;
using System.Text;
namespace Family
{
    internal class Persons
    {
        public string name;
        public int age;

        public Persons(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }
}
