internal class Средноаритметично_по_редове
{
    private static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += matrix[i, j];
                Console.Write($"{matrix[i, j], 10} ");
            }
            Console.WriteLine($"{(sum / cols), 10:F2}");
        }
    }
}