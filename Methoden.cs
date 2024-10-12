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

static void InsertionSort(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int key = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];
            j--;
        }

        array[j + 1] = key;
    }
}

static void InsertionSortById(TempClass[] temps)
{
    for (int i = 1; i < temps.Length; i++)
    {
        TempClass key = temps[i];
        int j = i - 1;

        while (j >= 0 && temps[j].getId() > key.getId())
        {
            temps[j + 1] = temps[j];
            j--;
        }

        temps[j + 1] = key; 
    }
}

static void WriteToFile(string filePath, string[] lines)
{
    try
    {
        //OUTPUT FILE MUSS .OUT ENDEN
        File.WriteAllLines(filePath, lines);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Fehler beim Schreiben in die Datei: {ex.Message}");
    }
}