internal class Минимум_по_колони
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
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int j = 0; j < cols; j++)
        {
            int min = int.MaxValue;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
            Console.Write(min + " ");
        }
    }
}