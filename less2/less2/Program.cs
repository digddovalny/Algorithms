
using System;

class Program 
{
    static void Main(string[] args)
    {
        
        static int[] bubleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i+1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

        Console.WriteLine("Начальный массив: ");
        int[] array = new int[] { 1, 4, 9, 6, 5, 0, 4, 7, 1, 8 };
        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine("Отсортированный массив");
        int[] arr = bubleSort(array);
        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine();
    }
}
