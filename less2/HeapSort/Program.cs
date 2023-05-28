//Реализовать алгоритм пирамидальной сортировки (сортировка кучей).

using HeapSortNameSpace;

class Program 
{
    public static void Main(string[] args) 
    {

        int[] array = new int[] { 1, 4, 9, 6, 5, 0, 4, 7, 1, 8 };
        int n = array.Length;

        HeapSort heapSort = new HeapSort();
        heapSort.sort(array);

        Console.WriteLine("Начальный массив: ");
        Console.WriteLine(string.Join(", ", array));

        Console.WriteLine("Отсортированный массив:");
        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine();
    }
}
