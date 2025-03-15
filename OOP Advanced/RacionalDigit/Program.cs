using RacionalDigit;

RacionalNumber[] numbers = new RacionalNumber[3];
for (int i = 0; i < 3; i++)
{
    int firstNumber = int.Parse(Console.ReadLine());
    int secondNumber = int.Parse(Console.ReadLine());
    numbers[i] = new RacionalNumber { firstRacional = firstNumber, secondRacional = secondNumber };
}
foreach (RacionalNumber number in numbers)
{
    Console.WriteLine(number.GetString());
}