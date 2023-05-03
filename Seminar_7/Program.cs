// //Задать двумерный массив размером m x n, заполненный случайными целыми числами.

// int [,] GetArray (int rows, int cols, int minValue = 0, int maxValue = 10)
// {
//     int[,] array = new int [rows, cols];
//     var rnd = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = rnd.Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void PrintArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int [,] array = GetArray(3, 4);
// PrintArray(array);


//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
//  Выведите полученный массив на экран. m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int [,] FillArray (int rows, int cols)
// {
//     int[,] array = new int [rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void PrintArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }


// int [,] array = FillArray(3, 4);
// PrintArray(array);


// Задайте двумерный массив, заполните его случайными числами. 
// Найдите сумму элементов на главной диагонали (главная диагональ – это те элементы, которые имеют индекс (0, 0), (1, 1)…).
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// int [,] GetArray (int rows, int cols, int minValue = 0, int maxValue = 9)
// {
//     int[,] array = new int [rows, cols];
//     var rnd = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = rnd.Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void PrintArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }


// int SumDiagonalArray (int [,] array)
// {
//     int result = 0;
//     int mainDiagonalLength = array.GetLength(0) > array.GetLength(1) ? array.GetLength(1) : array.GetLength(0);
//     for (int i = 0; i < mainDiagonalLength; i++)
//     {
//         result += array[i, i];
//     }
//     return result;
// }

// int [,] array = GetArray(4, 5);
// PrintArray(array);
// System.Console.WriteLine(SumDiagonalArray(array));




// //Задать двумерный массив, заполненый рандомными числами. 
// // Найти элементы у которых оба индекса нечетные и заменить эти элементы на их квадраты.

// int [,] GetArray (int rows, int cols, int minValue = 0, int maxValue = 9)
// {
//     int[,] array = new int [rows, cols];
//     var rnd = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = rnd.Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void PrintArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void GetModifArray (int [,] array)
// {
//     for (int i = 1; i < array.GetLength(0); i += 2)
//     {
//         for (int j = 1; j < array.GetLength(1); j += 2)
//         {
//             array[i, j] *= array[i, j];
//         }
//     }
// }

// int[,] array = GetArray(5, 5);
// PrintArray(array);
// GetModifArray(array);
// PrintArray(array);