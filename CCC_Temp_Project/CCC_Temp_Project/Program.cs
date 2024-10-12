//CCC 2024 Jonas Moser

using System.Xml;

namespace CccTempProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temp Project");

            string path = "output/output.out";

            string[] test =
            {
                "aaaa",
                "BBBBB",
                "CCCCC",
                "DDDDD"
            };
            
            WriteToFile(path, test);
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
    }
}