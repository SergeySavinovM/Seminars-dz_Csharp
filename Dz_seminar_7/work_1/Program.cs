// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] GetArray (int rows, int cols, int minValue = 0, int maxValue = 10)
{
    double[,] array = new double [rows, cols];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return array;
}

void PrintArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double number = array[i, j];
            System.Console.Write(number.ToString("F2") + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double [,] array = GetArray(3, 4);
PrintArray(array);