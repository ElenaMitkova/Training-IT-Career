using Statistics;

int counter = int.Parse(Console.ReadLine());
Person[] people = new Person[counter];
for (int i = 0; i < counter; i++)
{
    string[] input = Console.ReadLine().Split();
    people[i] = new Person { Name = input[0], Age = int.Parse(input[1]) };
}
foreach (Person person in people.Where(x => x.Age > 30).OrderBy(x => x.Name))
{
    Console.WriteLine($"{person.Name} {person.Age}");
}