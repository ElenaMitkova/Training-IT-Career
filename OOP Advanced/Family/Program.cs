using Family;

int counter = int.Parse(Console.ReadLine());
Person[] family = new Person[counter];
for (int i = 0; i < counter; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    family[i] = new Person {Name = input[0], Age = int.Parse(input[1]) };
}
foreach (Person member in family.OrderBy(x => x.Name))
{
    Console.WriteLine($"{member.Name} {member.Age}");
}