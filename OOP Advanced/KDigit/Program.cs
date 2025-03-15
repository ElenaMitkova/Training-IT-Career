using KDigit;

List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int k = int.Parse(Console.ReadLine());
Digits[] evens = new Digits[numbers.Count];
for (int i = 0; i < numbers.Count; i++)
{
    evens[i] = new Digits { Number = numbers[i] };
}
foreach (Digits even in evens.Where(x => x.Number % k == 0))
{
    Console.WriteLine($"{even.Number} ");
}