// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDist(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double distance = Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2) + Math.Pow(z1 - z2, 2);
    distance = Math.Sqrt(distance);
    distance = Math.Round(distance, 2);
    return distance;
}

System.Console.WriteLine("Введите первое число по оси Х");
double x1 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число по оси Х");
double x2 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите первое число по оси Y");
double y1 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число по оси Y");
double y2 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите первое число по оси Z");
double z1 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число по оси Z");
double z2 = double.Parse(Console.ReadLine()!);

System.Console.WriteLine("Расстояние между точками = "+ GetDist(x1, y1, x2, y2, z1, z2));