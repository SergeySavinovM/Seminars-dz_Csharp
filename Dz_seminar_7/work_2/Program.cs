// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] GetArray (int rows, int cols, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int [rows, cols];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void FindingValue (int [,] array, int oneValue, int twoValue)
{
    if (array.GetLength(0) > oneValue && array.GetLength(1) > twoValue)
    {
        System.Console.WriteLine($"Число с такими координатами существует - {array[oneValue, twoValue]}");
    }
    else
    {
        System.Console.WriteLine("такого числа в массиве нет");
    }
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int [,] array = GetArray(3, 4);
PrintArray(array);

FindingValue(array, 2, 3);