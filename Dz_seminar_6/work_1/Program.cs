// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

System.Console.Write("Введите число количество чисел сколько вы хотите ввести ");
int userNum = Convert.ToInt32(Console.ReadLine());

void Zapros (int number)
{
    int count = 0;
    int numberUser = 0;
    for (int i = 0; i < number; i++)
    {
        System.Console.Write($"Введите {i + 1}-й элемент: ");
        numberUser = Convert.ToInt32(Console.ReadLine());
        if (numberUser > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Количество чисел больше 0 -  {count}");;
}

Zapros(userNum);

