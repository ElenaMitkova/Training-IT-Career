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
        int firstDiagonalSum = 0, secondDiagonalSum = 0, underDiagonalSum = 0, aboveDiagonalSum = 0;
        int even = 0, rowSum = 0, colSum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == j)
                {
                    firstDiagonalSum += matrix[i, j];
                    if (matrix[i, j] % 2 == 0)
                    {
                        even += matrix[i, j];
                    }
                }
                if (i + j == cols - 1)
                {
                    secondDiagonalSum += matrix[i, j];
                }
                if (j > i)
                {
                    aboveDiagonalSum += matrix[i, j];
                }
                if (j < i)
                {
                    underDiagonalSum += matrix[i, j];
                }
                if ((i == 0 || i == rows - 1) && matrix[i, j] % 2 == 0)
                {
                    rowSum += matrix[i, j];
                }
                if ((j == 0 || j == cols - 1) && matrix[i, j] % 2 == 1)
                {
                    colSum += matrix[i, j];
                }
            }
        }
        if (firstDiagonalSum == secondDiagonalSum && underDiagonalSum % 2 == 1 && aboveDiagonalSum % 2 == 0)
        {
            double prize = (underDiagonalSum + even + rowSum + colSum) / 4;
            Console.WriteLine("YES");
            Console.WriteLine($"The amount of money won is: {prize:F2}");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}