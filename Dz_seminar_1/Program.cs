// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// // какое число большее, а какое меньшее.

// Console.Write("Введите первое число ");
// int userNum1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число ");
// int userNum2 = Convert.ToInt32(Console.ReadLine());

// if(userNum1 > userNum2)
// {
//     Console.WriteLine($"Число {userNum1} больше числа {userNum2}.");
// }
// else if(userNum1 < userNum2)
// {
//     Console.WriteLine($"Число {userNum2} больше числа {userNum1}.");
// }
// else
// {
//     Console.WriteLine($"Вы ввели одинаковые числа");
// }

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите первое число ");
// int userNum1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число ");
// int userNum2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число ");
// int userNum3 = Convert.ToInt32(Console.ReadLine());

// if(userNum1 > userNum2 && userNum1 > userNum3)
// {
//     Console.WriteLine($" {userNum1} максимальное число");
// }
// else if(userNum2 > userNum1 && userNum2 > userNum3)
// {
//     Console.WriteLine($" {userNum2} максимальное число");
// }
// else
// {
//     Console.WriteLine($" {userNum3} максимальное число");
// }

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// //  является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите число ");
// int userNum = Convert.ToInt32(Console.ReadLine());

// if(userNum % 2 == 0)
// {
//     Console.WriteLine("Данное число является четным");
// }
// else
// {
//     Console.WriteLine("Данное число является не четным");
// }

// // Задача 8: Напишите программу, которая на вход принимает число (N),
// //  а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Введите число ");
// int userNum = Convert.ToInt32(Console.ReadLine());

// int count = 2;
// if(userNum >= 0)
// {
//     while(count <= userNum)
//     {
//         Console.WriteLine($"{count} ");
//         count += 2;
//     }
// }
// else
// {
//     count = 0;
//       while(count >= userNum)
//     {
//         Console.WriteLine($"{count} ");
//         count += -2;
//     }
// }
