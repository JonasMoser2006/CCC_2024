internal class Program
{
    public static void Main(string[] args)
    {
        string[] data = File.ReadAllLines("../../../data/level1_1.in");

        int n = Convert.ToInt32(data[0]);
        int c = Convert.ToInt32(data[1]);

        int[][] currencies = new int[n][];
        
        for (int i = 0; i < n; i++)
        {
            currencies[i] = data[i + 2].Split(' ').Select(int.Parse).ToArray();
        }
        
        for (int i = 0; i < n; i++)
        {
            int result = FindSmallestPossibleValue(currencies[i]);
            Console.WriteLine(result);
        }
    }

    public static int FindSmallestPossibleValue(int[] values)
    {
        int result = values[values.Length - 1] + 1;
        bool hasSmallest = false;

        for (int i = 0; i < values.Length && !hasSmallest; i++)
        {
            if (i + 1 < values.Length && values[i] != values[i + 1] - 1)
            {
                hasSmallest = true;
                result = values[i] + 1;
            }
        }
        
        return result;
    }
}