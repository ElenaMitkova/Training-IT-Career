using NotEvenNumber;

List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
NotEven[] evens = new NotEven[numbers.Count];
for (int i = 0; i < numbers.Count; i++)
{
    evens[i] = new NotEven { Number = numbers[i] };
}
foreach (NotEven even in evens.Where(x => x.Number % 2 == 1))
{
    Console.WriteLine($"{even.Number} ");
}