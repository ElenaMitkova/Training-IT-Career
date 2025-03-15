using UniversalBoxForDigits;

int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    Box<int> number = new Box<int>();
    number.Value = int.Parse(Console.ReadLine());
    Console.WriteLine(number);
}