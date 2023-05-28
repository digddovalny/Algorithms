
class Program 
{
    static void Main(string[] args)
    {
        static void QuickSort(int[] arr, int start, int end) 
        {
            int pivot = arr[(end - start) / 2 + start];
            int leftPosition = start;
            int rightPosition = end;
            int temp;
            while (leftPosition <= rightPosition)
            {
                while (arr[leftPosition] < arr[pivot])
                {
                    leftPosition++;
                }

                while (arr[rightPosition] > arr[pivot])
                {
                    rightPosition--;
                }

                if (leftPosition <= rightPosition)
                {
                    if (leftPosition < rightPosition)
                    {
                        temp = arr[leftPosition];
                        arr[leftPosition] = arr[rightPosition];
                        arr[rightPosition] = temp;
                    }
                    leftPosition++;
                    rightPosition--;
                }
            }
            if (start < rightPosition)
            {
                QuickSort(arr, start, rightPosition);
            }
            if (end > leftPosition)
            {
                QuickSort(arr, leftPosition, end);
            }
        }

        Console.WriteLine("Начальный массив: ");
        int[] array = new int[] { 1, 4, 9, 6, 5, 0, 4, 7, 1, 8 };
        Console.WriteLine(string.Join(", ", array));
        QuickSort(array, 0, array.Length);
        Console.WriteLine("Отсортированный массив:");
        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine();
    }
}