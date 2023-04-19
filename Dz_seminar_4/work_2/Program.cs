//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits(int num)
{
    int result = 0;
    while(num > 0)
    {
        int num1 = num % 10;
        result = result + num1;
        num = num / 10;
    }
    return result;
}
System.Console.WriteLine(SumOfDigits(11234));
