using UniversalBox;

int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    Box<string> input = new Box<string>();
    input.Value = Console.ReadLine();
    Console.WriteLine(input);
}