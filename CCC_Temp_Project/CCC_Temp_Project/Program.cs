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
        
        
    }
    
}