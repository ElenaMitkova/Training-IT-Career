int counter = int.Parse(Console.ReadLine());
//string[] inputs = new string[counter];
int[] inputs = new int[counter];
for (int i = 0; i < counter; i++)
{
    //inputs[i] = Console.ReadLine();
    inputs[i] = int.Parse(Console.ReadLine());
}
int[] positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Swap(inputs, positions[0], positions[1]);
Console.WriteLine(string.Join(' ', inputs));
static void Swap<T>(T [] inputs, int position1, int position2)
{
    T temp = inputs[position1];
    inputs[position1] = inputs[position2];
    inputs[position2] = temp;
}