// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string Comparison(int num)
{
    if(num > 9999 && num < 100000)
    {
    int firstDigit = num / 10000;
    int num1 = num / 1000; 
    int secondDigit = num1 % 10;
    int num2 = num % 100;
    int fourthDigit = num2 / 10;
    int fifthDigit = num % 10;
    
    string Comparison = "Число не является палиндромом";
    if(firstDigit == fifthDigit && secondDigit == fourthDigit)Comparison = "Число является палиндромом";

        return Comparison;
    }

    return "Вы ввели не пятизначное число";
}
System.Console.WriteLine(Comparison(68886));
