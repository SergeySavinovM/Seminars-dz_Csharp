// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7, которое обозначает день недели");
int userNum = Convert.ToInt32(Console.ReadLine());

if(userNum == 1)
{
    Console.WriteLine("Увы, еще рабочий день, понедельник");
}
else if(userNum == 2)
{
    Console.WriteLine("Увы, еще рабочий день, вторник");
}
else if(userNum == 3)
{
    Console.WriteLine("Увы, еще рабочий день, среда");
}
else if(userNum == 4)
{
    Console.WriteLine("Увы, еще рабочий день, четверг");
}
else if(userNum == 5)
{
    Console.WriteLine("Увы, еще рабочий день, пятница");
}
else if(userNum == 6)
{
    Console.WriteLine("Ура! Выходной! Суббота");
}
else if(userNum == 7)
{
    Console.WriteLine("Ура! Выходной! Воскресенье");
}
else
{
    Console.WriteLine("Вы ввели не корректную цифру. Попробуйте еще.");
}