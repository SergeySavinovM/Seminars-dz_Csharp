// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetRandomeArray(int lenght = 5, int minValue = 1, int maxValue = 100)   
{
    int [] array = new int [lenght];                                            
    for (int i = 0; i < lenght; i++)                                            
    {
        array[i] = new Random().Next(minValue, maxValue);                       
    }
    return array;                                                               
}

int SumNumberEvenIndex (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int [] mass = GetRandomeArray();
System.Console.WriteLine(string.Join(" ",mass));

int number = SumNumberEvenIndex(mass);
System.Console.WriteLine(number);