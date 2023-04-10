using System;

class Program
{
    static void Main(string[] args)
    {
        string[] array1 = new string[] {"123", "13", "hello", "world", "qwe"};
        string[] array2 = new string[array1.Length];

        // Заполнение второго массива элементами из первого массива, длина которых меньше или равна 3
        SecondArrayWithIF(array1, array2);

        // Вывод элементов второго массива на консоль
        PrintArray(array2);
    }

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
