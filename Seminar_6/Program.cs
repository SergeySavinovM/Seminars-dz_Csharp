// //Написать программу, которая перевернет одномерный массив в другую сторону.

// int[] GetRandomeArray(int lenght = 7, int minValue = 0, int maxValue = 10)   
// {
//     int [] array = new int [lenght];                                            
//     for (int i = 0; i < lenght; i++)                                            
//     {
//         array[i] = new Random().Next(minValue, maxValue);                       
//     }
//     return array;                                                               
// }

// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void Swap (int ind1, int ind2, int [] array)
// {
//     int temp = array[ind1];
//     array[ind1] = array[ind2];
//     array[ind2] = temp;
// }

// void ReverceArray (int [] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         Swap (i, array.Length - 1 - i, array);
//         // int temp = array[i];
//         // array[i] = array[^(i + 1)];              //можно сделать так и тогда функцию "Swap" можно не использовать
//         // array[^(i + 1)] = temp;
//     }
// }

// int [] mass = GetRandomeArray();
// ShowArray(mass);

// ReverceArray(mass);

// ShowArray(mass);


//Написать программу, которая принимает три числа и проверяет может ли существовать треугольник с такими сторонами

// string ЕriangleСheck (int a, int b, int c)
// {
//     string result = " ";
//     if (a < b + c & b < a + c & c < a + b)
//     {
//         result = "Треугольник существует!";
//     }
//     else
//     {
//         result = "Треугольник не может существовать с такими сторонами!";
//     }
//     return result;
// }

// System.Console.WriteLine(ЕriangleСheck(3, 5, 7));


//Решение для любоуго угольника


// bool FigureCanExist (int [] sides)
// {
//     for (int i = 0; i < sides.Length; i++)
//     {
//         int SumOtherSides = 0;
//         for (int j = 0; j < sides.Length; j++)
//         {
//             SumOtherSides += sides[j];
//         }
//         if (sides[i] >= SumOtherSides - sides[i]) return false;
//     }
//     return true;
// }

// System.Console.Write("Введите колличество сторон: ");
// string number = Console.ReadLine()!;
// int N = Int32.Parse(number);
// int [] figure = new int [N];

// for (int i = 0; i < N; i++)
// {
//     System.Console.Write($"Введите длину стороны {i + 1}: ");
//     number = Console.ReadLine()!;
//     figure[i] = Int32.Parse(number);
// }
// System.Console.WriteLine($"Это может быть фигура {FigureCanExist(figure)}");



//Написать программу, которая переводит число из десятичной ситсемы изчисления в двоичную.


// System.Console.Write("Введите число: ");
// int userNum = Convert.ToInt32(Console.ReadLine());

// string[] NumberTranslation (int number)
// {
//     string[] itog = new string [number];
//     int result = number;
//     for (int i = 0; i < number; i++)
//     {
//         itog[i] += result % 2;
//         result /= 2; 
//         if (result < 1)
//         {
//             break;
//         }
//     }
//     return itog;
// }


// void ReverceArray (string [] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         string temp = array[i];
//         array[i] = array[^(i + 1)];             
//         array[^(i + 1)] = temp;
//     }
// }

// string[] massNumber = NumberTranslation(userNum);
// ReverceArray(massNumber);
// System.Console.WriteLine(string.Join("",massNumber));

