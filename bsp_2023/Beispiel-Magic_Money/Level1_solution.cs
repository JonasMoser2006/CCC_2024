using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Pfad zur Input-Datei
        string filePath = "./Input_data/level1_5.in";
        
        // Lese die Datei ein
        string[] lines = File.ReadAllLines(filePath);
        
        // Parse der ersten beiden Zeilen
        int N = int.Parse(lines[0]); // Anzahl der Währungen
        int C = int.Parse(lines[1]); // Anzahl der Münzen pro Währung
        
        // Initialisiere ein Array für die Währungen
        int[][] currencies = new int[N][];
        
        // Lese die Münzwerte für jede Währung
        for (int i = 0; i < N; i++)
        {
            // Splitte die Werte der Währung und konvertiere sie zu Int
            currencies[i] = lines[i + 2].Split(' ').Select(int.Parse).ToArray();
        }

        // Finde und gib das Ergebnis für jede Währung aus
        for (int i = 0; i < N; i++)
        {
            int result = FindSmallestNonConstructibleAmount(currencies[i]);
            Console.WriteLine(result);
        }
    }

    static int FindSmallestNonConstructibleAmount(int[] coins)
    {
        int smallestNonConstructibleAmount = 1;
        int test = 0;

        for (int i = 0; i < coins.Length; i++)
        {
            if (i == 0)
            {
                test = coins[0];
            }

            if (coins[i] != test)
            {
                smallestNonConstructibleAmount = test++;
                break;
            }
            else
            {
                test++;
            }
        }

        return smallestNonConstructibleAmount;
    }
}