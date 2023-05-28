
class Program 
{
    static void Main()
    {
        static int BinarySearch(int[] array, int value, int min, int max)
        {
            int midPoint;
            if (max < min)
            {
                return -1;
            }
            else
            {
                midPoint = (max - min) / 2 + min;
            }
            if (array[midPoint] < value)
            {
                return BinarySearch(array, value, midPoint+1, max);
            }
            else
            {
                if (array[midPoint]> value)
                {
                    return BinarySearch(array, value, min, midPoint-1);
                }
                else
                {
                    return midPoint;
                }
            }
        }

        Console.WriteLine("начинаем поиск: ");
        int[] array = new int[] { 1, 2, 3, 4, 5, 8, 10, 55, 100, 300 };
        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine(BinarySearch(array, 5, 0, array.Length - 1));
        Console.WriteLine();
    }
}