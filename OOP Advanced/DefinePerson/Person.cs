using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DefinePerson
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string IntroduseYourself()
        {
            return $"I am {Name}. I am {Age}-years old.";
        }
    }
}