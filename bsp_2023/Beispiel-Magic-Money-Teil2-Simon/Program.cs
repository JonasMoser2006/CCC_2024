internal class Program
{
    public static void Main(string[] args)
    {
        string[] data = File.ReadAllLines("../../../data/level2_3.in");

        int n = Convert.ToInt32(data[0]);
        int c = Convert.ToInt32(data[1]);
        int a = Convert.ToInt32(data[2]);
        
        int[] values = new int[5];

        int[] targets = new int[3];

        for (int i = 3; i < data.Length; i+=2)
        {
            // Komplettes String array in Int array konvertieren
            values = Array.ConvertAll(data[i].Split(" "), int.Parse);
            targets = Array.ConvertAll(data[i + 1].Split(" "), int.Parse);
            
            CallFindTwoSum(values, targets);
        }
    }

    public static void CallFindTwoSum(int[] values, int[] targets)
    {
        foreach (int target in targets)
        {
            int[] result = FindTwoSum(values, target);
            Console.WriteLine($"{result[0]} + {result[1]} -> {target}");
        }
    }

    public static int[] FindTwoSum(int[] values, int target)
    {
        int[] result = new int[2];
        bool hasValues = false;

        for (int i = 0; i < values.Length && !hasValues; i++)
        {
            // target = values[i] + x -> target - values[i] = x
            if (values.Contains(target - values[i]))
            {
                result[0] = values[i];
                result[1] = target - values[i];
                hasValues = true;
            }
        }
        
        return result;
    }
}