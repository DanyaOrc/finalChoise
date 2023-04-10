using System;

class Program
{

    // Метод, который заполняет второй массив элементами из первого массива, длина которых меньше или равна 3
    static void SecondArrayWithIF(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            // Если длина текущего элемента первого массива меньше или равна 3, то добавляем его во второй массив
            if(array1[i].Length <= 3)
            {
                array2[count] = array1[i];
                count++;
            }
        }
    }

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
