// // Task.1
// int GetNemberOfQuarter(int x, int y)
// {
//     if(x > 0 && y > 0)
//     {
//         return 1;
//     }
//     else if(x < 0 && y > 0)
//     {
//         return 2;
//     }
//     else if(x < 0 && y < 0)
//     {
//         return 3;
//     }
//     else if(x > 0 && y < 0)
//     {
//         return 4;
//     }
//      else
//     {
//         return -1;
//     }
// }

// Console.WriteLine(GetNemberOfQuarter(11, -5));
// Console.WriteLine(GetNemberOfQuarter(-11, -5));
// Console.WriteLine(GetNemberOfQuarter(11, 5));
// Console.WriteLine(GetNemberOfQuarter(-11, 5));
// Console.WriteLine(GetNemberOfQuarter(0, -5));


// // Task.2
// int[] arr = {12, 4, 65, 5, 3, 11};
// string result = string.Join(",", arr);
// System.Console.WriteLine(result);


// string input = "1 2 3 4 5";
// var res = input.Split().Select(int.Parse).ToArray();
// foreach (var num in res)
// {
//     System.Console.WriteLine(num);
// }
// Console.ReadLine()!.Split(", ").Select(int.Parse).ToArray();

// Задача 18. Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

// string Intervals(int num)

// {
//     string Intervals = "error";
//     if(num == 1) Intervals = "x (0; +inf) y(0; +inf)";
//     else if(num == 2) Intervals =  "x(-inf; 0) y(0; +inf)";
//     else if(num == 3) Intervals = "x(-inf; 0) y(-inf; 0)";
//     else if(num == 4) Intervals = "x(0; +inf) y(-inf; 0)";

//     return Intervals;
// }
// Console.WriteLine(Intervals(1));


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

// double GetDist(double x1, double x2, double y1, double y2)
// {
//     double distance = Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2);
//     distance = Math.Sqrt(distance);
//     distance = Math.Round(distance, 2);
//     return distance;
// }

// System.Console.WriteLine("Введите первое число по оси Х");
// double x1 = double.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите второе число по оси Х");
// double x2 = double.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите первое число по оси Y");
// double y1 = double.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите второе число по оси Y");
// double y2 = double.Parse(Console.ReadLine()!);

// System.Console.WriteLine("Расстояние между точками = "+ GetDist(x1, y1, x2, y2));

