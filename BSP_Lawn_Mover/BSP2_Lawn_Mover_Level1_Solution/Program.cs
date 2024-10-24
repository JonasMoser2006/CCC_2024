// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        for (int fileNo = 1; fileNo <= 5; fileNo++)
        {
            string[] data = File.ReadAllLines($"../../../data/level1_{fileNo}.in");

            for (int i = 1; i < data.Length; i++)
            {
                int[] result = CountDirections(data[i]);
                string content = $"{result[0]} {result[1]} {result[2]} {result[3]}";
                File.AppendAllText($"../../../out/level1_{fileNo}.out", content + Environment.NewLine);
            }
        }
    }
    
    // W, D, S, A

    public static int[] CountDirections(string line)
    {
        int[] counts = new int[4];
        
        foreach(char character in line)
        {
            switch (character)
            {
                case 'W':
                    counts[0]++;
                    break;
                case 'D':
                    counts[1]++;
                    break;
                case 'S':
                    counts[2]++;
                    break;
                case 'A':
                    counts[3]++;
                    break;
            }
        }

        return counts;
    }
}