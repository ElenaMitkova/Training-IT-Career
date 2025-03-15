using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
namespace Списък_на_служители
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            while (n > 0)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string work = input[2];
                string otdel = input[3];
                string poste = input.Length>4?input[4]:"n/a";
                int age = -1;
                if(input.Length > 5 && int.TryParse(input[5], out int parsedAge))
                {
                    age = parsedAge;
                }
                Employee employee = new Employee(name, salary, work, otdel, poste,age);
                employees.Add(employee);
                n--;
            }
            var output = employees.GroupBy(e => e.Otdel).Select(e => new
            { Department = e.Key, AvarageSalary = e.Average(e => e.Salary) })
                .OrderByDescending(t=>t.AvarageSalary).First().Department;
            var finalOutput = employees.Where(e => e.Otdel == output).OrderByDescending(e => e.Salary);
            Console.WriteLine($"Highest Average Salary: {output}");
            foreach (var item in finalOutput)
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2} {item.Inbox} {item.Age}");
            }
        }
    }
}
