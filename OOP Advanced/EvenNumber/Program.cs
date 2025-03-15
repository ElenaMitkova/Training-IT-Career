using EvenNumber;

List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
Even[] evens = new Even[numbers.Count];
for (int i = 0; i < numbers.Count; i++)
{
    evens[i] = new Even { Number = numbers[i] };
}
foreach (Even even in evens.Where(x => x.Number % 2 == 0))
{
    Console.WriteLine($"{even.Number} ");
}