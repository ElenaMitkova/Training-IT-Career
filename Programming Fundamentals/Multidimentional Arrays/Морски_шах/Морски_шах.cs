internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            char[] chars = Console.ReadLine().Split().Select(char.Parse).ToArray();
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = chars[j];
            }
        }
        if (matrix[0, 0] == matrix[0, 1] && matrix[0, 1] == matrix[0, 2])
        {
            Console.WriteLine("Win");
        }
        else if (matrix[1, 0] == matrix[1, 1] && matrix[1, 1] == matrix[1, 2])
        {
            Console.WriteLine("Win");
        }
        else if (matrix[2, 0] == matrix[2, 1] && matrix[2, 1] == matrix[2, 2])
        {
            Console.WriteLine("Win");
        }
        else if (matrix[0, 0] == matrix[1, 0] && matrix[1, 0] == matrix[2, 0])
        {
            Console.WriteLine("Win");
        }
        else if (matrix[0, 1] == matrix[1, 1] && matrix[1, 1] == matrix[2, 1])
        {
            Console.WriteLine("Win");
        }
        else if (matrix[0, 2] == matrix[1, 2] && matrix[1, 2] == matrix[2, 2])
        {
            Console.WriteLine("Win");
        }
        else if (matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
        {
            Console.WriteLine("Win");
        }
        else if (matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
        {
            Console.WriteLine("Win");
        }
        else
        {
            Console.WriteLine("Lose");
        }
    }
}