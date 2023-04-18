// // принимает на вход число N и выдает сумму чисел от 1 до N.

// int SumFrom1ToN(int n)
// {
//     int sum = 0;
//     for (int i = 0; i <= n; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// System.Console.WriteLine(SumFrom1ToN(100));

// int SumFrom1ToN1(int n)
// {
//     return n * (n + 1) / 2;
// }
// System.Console.WriteLine(SumFrom1ToN1(100));

//Написать программу, которая принимает на вход число и выдает количество цифр в числе.

// int FindingNumbers(int number)
// {
//     int count = 0;
//     while(number > 0)
//     {
//         count++;
//         number = number / 10;
//     }
//     return count;
// }
// System.Console.WriteLine(FindingNumbers(123));

// Второе решение предыдущей задачи

// int FindingNumbers(int number)
// {
//     int count;
//     for (count = 0; number > 0; count++)
//     {
//         number = number / 10;
//     }
//     return count;
// }
// System.Console.WriteLine(FindingNumbers(123));


//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int[] RandomNumber(int length)
// {
//     int [] arr = new int[length];
//     Random rnd = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = rnd.Next(2);
//     }
//     return arr;
// }
// int [] RandomArry = RandomNumber(8);
// string ArrayString = string.Join(",", RandomArry);
// System.Console.WriteLine(ArrayString);



// int[] array = {1, 3, 5, 7, 9, 11};
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(i != 0 ? ("," + array[i]) : (array[i]));
// }
// System.Console.WriteLine();

//или

// int[] array = {1, 3, 5, 7, 9, 11};

// for (int i = 0; i < array.Length; i++)
// {
//     if (i != 0)
//     System.Console.Write("," + array[i]);
//     else
//     System.Console.Write(array[i]);
// }
// System.Console.WriteLine();



// void Foo(int a)
// {
//     a = 2;
// }

// int number = 1000;
// Foo(number);
// System.Console.WriteLine(number);

// void Bar(int[] array)
// {
//     array[0] = 1000;
// }
// int[] mass = {1};
// Bar(mass);
// System.Console.WriteLine(mass[0]);
