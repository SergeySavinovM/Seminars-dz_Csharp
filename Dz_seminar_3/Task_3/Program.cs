// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число ");
int userNum = Convert.ToInt32(Console.ReadLine());

int count = 1;
while(count <= userNum)
{
    int result = (count * count) * count;
    Console.WriteLine(result);
    count++;
}