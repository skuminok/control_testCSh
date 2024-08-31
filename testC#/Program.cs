using System;

class Program
{
    static void Main()
    {
        // Задаем исходный массив строк
        string[] initialArray = { "Hello", "2", "world", ":-)", "cat", "dog", "sun" };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(initialArray);

        // Получаем новый массив строк длиной <= 3 символов
        string[] resultArray = GetShortStringsArray(initialArray);

        // Выводим результат
        Console.WriteLine("\nМассив строк длиной <= 3 символов:");
        PrintArray(resultArray);
    }

    static string[] GetShortStringsArray(string[] inputArray)
    {
        // Сначала считаем количество строк, длина которых <= 3 символов
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив для хранения коротких строк
        string[] outputArray = new string[count];
        int index = 0;

        // Заполняем новый массив строками длиной <= 3 символов
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                outputArray[index] = inputArray[i];
                index++;
            }
        }

        return outputArray;
    }

    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\"{array[i]}\"");
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}