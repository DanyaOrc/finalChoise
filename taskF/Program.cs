using System;

class Program
{
    // Метод, который выводит элементы массива на консоль
    static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}
