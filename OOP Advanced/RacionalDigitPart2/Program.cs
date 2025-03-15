using RacionalDigitPart2;

List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
RacionalDigit[] number = new RacionalDigit[numbers.Count/ 2];
for (int i = 0; i < number.Length; i++)
{
    number[i] = new RacionalDigit { firstRacional = numbers[2 * i], secondRacional = numbers[2 * i + 1] };
}
foreach (RacionalDigit item in number)
{
    Console.WriteLine($"{item}; ");
}