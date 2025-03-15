using System;
using System.Collections.Generic;
using System.Text;
namespace Списък_на_служители
{
    internal class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        private string work;
        public string Work
        {
            get { return work; }
            set { work = value; }
        }
        private string otdel;
        public string Otdel
        {
            get { return otdel; }
            set { otdel = value; }
        }
        private string inbox;
        public string Inbox
        {
            get { return inbox; }
            set { inbox = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Employee(string name, double salary, string work, string otdel, string inbox, int age)
        {
            Name = name;
            Salary = salary;
            Work = work;
            Otdel = otdel;
            Inbox = inbox;
            Age = age;
        }
    }
}