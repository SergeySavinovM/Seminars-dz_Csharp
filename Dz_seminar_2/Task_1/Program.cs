// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int GetRandomInt()
{
    int result = new Random().Next(100, 1000);
    return result;
}

int GetModifDigit(int number)
{
    int digit = number / 10;  
    digit = digit % 10; 
    return digit;
}

int number = GetRandomInt();
int itog = GetModifDigit(number);
Console.WriteLine(number);
Console.WriteLine(itog);