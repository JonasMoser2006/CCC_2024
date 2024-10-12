//CCC 2024 Jonas Moser
namespace CccTempProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temp Project");
        }

        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == target)
                {
                    return middle;
                }
                else if (array[middle] < target)
                { 
                    left = middle + 1;
                }
                else
                { 
                    right = middle - 1;    
                }
            }

            return -1; // if id isnt found
        }

        public static int BinarySearchFromObject(TempClass[] obj, int id)
        {
            int left = 0;
            int right = obj.Length - 1;
            
            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (obj[middle].getId() == id)
                {
                    return middle;
                }
                else if (obj[middle].getId() < id)
                { 
                    left = middle + 1;
                }
                else
                { 
                    right = middle - 1;    
                }
            }

            return -1; // if id isnt found
        }

        static string AsciiToString(string asciiString)
        {
            string[] asciiValues = asciiString.Split(' ');
            char[] characters = new char[asciiValues.Length];

            for (int i = 0; i < asciiValues.Length; i++)
            {
                int asciiCode = int.Parse(asciiValues[i]);
                characters[i] = (char)asciiCode; 
            }

            return new string(characters); 
        }
        
        static string StringToAscii(string input)
        {
            int[] asciiValues = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                asciiValues[i] = (int)input[i]; 
            }

            return string.Join(" ", asciiValues);
        }
        
        static string[] ReadFileAsLines(string filePath)
        {
            try
            {
                return File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Lesen der Datei: {ex.Message}");
                return new string[0]; 
            }
        }
        
        static string[] SplitStringBySpaces(string input)
        {
            return input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }
        
        
        
        
    }
    
}