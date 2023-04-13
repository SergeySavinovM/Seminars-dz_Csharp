// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThreeDigit( int number )
{
    return number % 10;
}

Console.Write("Введите число ");
int userNum = Convert.ToInt32(Console.ReadLine());

if(userNum > 99 && userNum < 1000)
{
    System.Console.WriteLine($"Третьей цифрой числа {userNum} является {ThreeDigit(userNum)}");
}
else if(userNum > 999)
{
    int userNumIzm = userNum;
    while (userNumIzm > 999)
    {
        userNumIzm = userNumIzm /10;
    }
        Console.WriteLine($"Третьей цифрой числа {userNum} является {ThreeDigit(userNumIzm)}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}