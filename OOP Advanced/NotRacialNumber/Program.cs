using Numbers;
List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
Number[] number = new Number[numbers.Count / 2 + 1];
for (int i = 0, j = 0; i < numbers.Count; i += 2, j++)
{
    number[j] = new Number { A = numbers[i], B = numbers[i + 1] };
}
foreach (Number num in number)
{
    Console.WriteLine($"{num}; ");
}