internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double[] sheetAverages = new double[n];
        int[] aboveTotalAvgCount = new int[n];
        double totalSum = 0;
        int totalSheets = 0;
        for (int sheet = 0; sheet < n; sheet++)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0], cols = dimensions[1];
            int minElement = int.MaxValue, maxElement = int.MinValue, sum = 0;
            int elementCount = rows * cols;
            int[] numbers = new int[elementCount];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    int num = rowValues[j];
                    numbers[index++] = num;
                    minElement = Math.Min(minElement, num);
                    maxElement = Math.Max(maxElement, num);
                    sum += num;
                }
            }
            double sheetAvg = (double)sum / elementCount;
            sheetAverages[sheet] = sheetAvg;
            totalSum += sheetAvg;
            totalSheets++;
            Console.WriteLine($"{minElement} {maxElement} {sheetAvg:F2}");
        }
        double totalAverage = totalSum / totalSheets;
        for (int sheet = 0; sheet < n; sheet++)
        {
            int count = sheetAverages[sheet] > totalAverage ? 1 : 0;
            aboveTotalAvgCount[sheet] = count;
        }
        Console.WriteLine(string.Join(" ", aboveTotalAvgCount));
    }
}