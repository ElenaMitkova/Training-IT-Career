using System;
using System.Collections.Generic;
using System.Text;
namespace Най_стария_член_на_фамилията
{
    internal class Person
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
		public Person()
		{

		}
        public int Age
		{
			get { return age; }
			set { age = value; }
		}
		
	}
}