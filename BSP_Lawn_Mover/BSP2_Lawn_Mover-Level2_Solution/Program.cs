// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        for (int fileNo = 1; fileNo <= 5; fileNo++)
        {
            string[] data = File.ReadAllLines($"../../../data/level2_{fileNo}.in");

            for (int i = 1; i < data.Length; i++)
            {
                int[] result = CalculateSmallestRectangle(data[i]);
                string content = $"{result[0]} {result[1]}";
                File.AppendAllText($"../../../out/level2_{fileNo}.out", content + Environment.NewLine);
            }
        }
    }

    public static int[] CalculateSmallestRectangle(string line)
    {
        int[] result = new int[2];

        int y = 0;
        int x = 0;

        int minX = 0;
        int maxX = 0;
        int minY = 0;
        int maxY = 0;

        foreach (char character in line)
        {
            switch (character)
            {
                case 'W':
                    y++;
                    break;
                case 'S':
                    y--;
                    break;
                case 'A':
                    x--;
                    break;
                case 'D':
                    x++;
                    break;
            }
            
            minX = Math.Min(minX, x);
            maxX = Math.Max(maxX, x);
            minY = Math.Min(minY, y);
            maxY = Math.Max(maxY, y);
        }
        
        result[0] = maxX - minX + 1; // width
        result[1] = maxY - minY + 1; // height
            
        return result;
    }
}