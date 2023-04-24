// // //Создамть массив из 12 чисел с случвйными числпми от _9 до 9; И найти сумму отдельно положительных и отрицательных чисел.

// int[] GetRandomeArray(int lenght = 12, int minValue = -9, int maxValue = 10)    //задали длину массива и его гравницы
// {
//     int [] array = new int [lenght];                                            //присвоили массиву длину
//     for (int i = 0; i < lenght; i++)                                            
//     {
//         array[i] = new Random().Next(minValue, maxValue);                       //цикл пробегается по каждому индексу и кладет туда рандомное значение
//     }
//     return array;                                                               
// }

// //или

// void FillRandomArray (int[] array, int minValue = -9, int maxValue = 10)        //если у нас уже есть массив(принимаем массив)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }
// }

// int [] mass1 = GetRandomeArray();   //вызов первого массива

// int [] mass2 = new int [5];         //вызов второго массива
// FillRandomArray(mass2);

// int SummPositivNumber (int [] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         sum += array[i] > 0 ? array[i] : 0;
//     }
//     return sum;
// }

// int SummNigativNumber (int [] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         sum += array[i] < 0 ? array[i] : 0;
//     }
//     return sum;
// }
// // или

//    int FilterSum (int [] array, bool positiv = true)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(positiv)
//         {
//             sum += array[i] > 0 ? array[i] : 0;
//         }
//         else
//         {
//             sum += array[i] < 0 ? array[i] : 0;
//         }
//     }
//     return sum;
// }
 
// System.Console.WriteLine(string.Join(" ", mass1));              //выводим массив с рандомными числами и добовляем пробел между ними

// System.Console.WriteLine(FilterSum(mass1));                     //выводим сумму положительных чисел

// System.Console.WriteLine(FilterSum(mass1,positiv : false));    //выводим сумму отрицательных чисел

                                        // //Замена метода "Join"
                                        // void ShowArray (int [] array)
                                        // {
                                        //     for (int i = 0; i < array.Length; i++)
                                        //     {
                                        //         System.Console.Write(array[i] + " ");
                                        //     }
                                        //     System.Console.WriteLine();
                                        // }

//Написать программу замены элементов массива: положительные элементы заменить на отрицательные, а отрицательные на положительные.

// int[] GetRandomeArray(int lenght = 7, int minValue = -9, int maxValue = 10)   
// {
//     int [] array = new int [lenght];                                            
//     for (int i = 0; i < lenght; i++)                                            
//     {
//         array[i] = new Random().Next(minValue, maxValue);                       
//     }
//     return array;                                                               
// }

// int[] RevercNumberArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//        array[i] *= -1;
//        System.Console.Write(array[i] + " ");
//     }
//     return array;
// }

// int [] mass1 = GetRandomeArray(); 
// System.Console.WriteLine(string.Join(" ", mass1));

// System.Console.WriteLine(RevercNumberArray(mass1));


//Задать массив. Написать программу которая определяет, присутствует ли заданное число в массиве.

// int[] GetRandomeArray(int lenght = 7, int minValue = 0, int maxValue = 10)   
// {
//     int [] array = new int [lenght];                                            
//     for (int i = 0; i < lenght; i++)                                            
//     {
//         array[i] = new Random().Next(minValue, maxValue);                       
//     }
//     return array;                                                               
// }
// int[] mass = GetRandomeArray();

// int SearchNumber (int[] array, int number)
// {  
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return i;
//         }
//     }
//     return -1;
// }

// System.Console.WriteLine(string.Join(" ",mass));
// System.Console.WriteLine(SearchNumber(mass, 5));

// //Решение через булево значение

// bool SearchNumber (int[] array, int number)
// {  
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return true;
//         }
//     }
//     return false;
// }

//Найти произведение пар чисел в одномерном массиве. Парой считается первый и последний эелемент, второй и предпоследний и т.д.

// int[] GetRandomeArray(int lenght, int minValue, int maxValue)   
// {
//     int [] array = new int [lenght];                                            
//     for (int i = 0; i < lenght; i++)                                            
//     {
//         array[i] = new Random().Next(minValue, maxValue);                       
//     }
//     return array;                                                               
// }

// int[] SummNumbers (int[] array)
// {
//     int[] array2 = new int [(array.Length + 1) / 2];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         array2[i] = array[i] * array[array.Length - 1 - i];
           //// array2[i] = array[i] * array[^(i + 1)];                      //то же самое, что и строкой выше
//     }
//     if (array.Length % 2 != 0)
//     {
//        //array2[array2.Length -1] = array[array.Length / 2];
//         array2[^1] = array[array.Length / 2];                            //то же самое, что и строкой выше
//     }
//     return array2;
// }

// int[] mass = GetRandomeArray(4, 1, 10);
// System.Console.WriteLine(string.Join(" ",mass));
// int[] mass2 = SummNumbers(mass);
// System.Console.WriteLine(string.Join(" ",mass2));