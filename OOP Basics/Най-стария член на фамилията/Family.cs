using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Най_стария_член_на_фамилията
{
    internal class Family
    {
        private List<Person> persons;

        public Family()
        {
            persons = new List <Person>();
        }

        public void AddMember(Person person)
        {
            persons.Add(person);
        }
        public void GetOldestMember()
        {
            var oldest = persons.OrderByDescending(person => person.Age).First();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
        
    }
}