internal class Program
{
    private static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = array[j];
            }
        }
        int maxSum = 0, indexX = 0, indexJ = 0;
        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    indexX = i;
                    indexJ = j;
                }
            }
        }
        Console.WriteLine($"{matrix[indexX, indexJ]} {matrix[indexX, indexJ + 1]}");
        Console.WriteLine($"{matrix[indexX + 1, indexJ]} {matrix[indexX + 1, indexJ + 1]}");
    }
}