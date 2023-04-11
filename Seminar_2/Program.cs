// Task.1.Написать программу, которая выводит случайное число из отрезка от 10 до 99 
// и показывает наибольшую его цифру.

// int GetRandomInt()
// {
//     int result = new Random().Next(10, 100);
//     return result;
// }
// Console.WriteLine(GetRandomInt());

// int GetMaxDigit(int number)
// {
//     int digit1 = number / 10;
//     int digit2 = number % 10;   
//     if( digit1 > digit2)
//     {
//         return digit1;
//     }
//     else
//     {
//         return digit2;
//     }
// }

// int number = GetRandomInt();
// int maxDigit = GetMaxDigit(number);
// System.Console.WriteLine(maxDigit);

// Task.2.

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// int GetRandomInt()
// {
//     int result = new Random().Next(100, 1000);
//     return result;
// }

// int GetModifDigit(int number)
// {
//     int delitDigit1 = number % 10;  
//     int delitDigit2 = (number / 100) * 10; 
//     number = delitDigit1 + delitDigit2;
//     return number;
// }
// int number = GetRandomInt();
// int itog = GetModifDigit(number);
// Console.WriteLine(number);
// Console.WriteLine(itog);
