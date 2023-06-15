using System;

class SortingAlgorithm
{
    static void Main()
    {
        // Создаем массив чисел для сортировки
        int[] array = ReadArrayFromInput();

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Вызываем алгоритм сортировки
        BubbleSort(array);

        Console.WriteLine("Отсортированный массив:");
        PrintArray(array);

        Console.ReadLine();
    }

    // Метод для ввода значений массива с клавиатуры
    static int[] ReadArrayFromInput()
    {
        Console.WriteLine("Введите элементы массива, разделенные пробелом:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int[] array = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }

        return array;
    }

    // Метод для печати массива
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // Алгоритм сортировки пузырьком
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Обмен элементов
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
