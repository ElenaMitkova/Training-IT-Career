using System;
using System.Collections.Generic;
using System.Text;
namespace Дефиниране_на_клас_човек
{
    internal class Person
    {
		public string name;
		public int age;

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

	}
}
