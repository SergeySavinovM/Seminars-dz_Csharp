// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] GetRandomeArray(int lenght = 10, int minValue = 1, int maxValue = 100)   
{
    int [] array = new int [lenght];                                            
    for (int i = 0; i < lenght; i++)                                            
    {
        array[i] = new Random().Next(minValue, maxValue);                       
    }
    return array;                                                               
}

int GerMinNumber (int [] array)
{
    int minValue = 100;
    for (int i = 0; i < array.Length; i++)
    {
        minValue = array[i] < minValue ? array[i] : minValue;
    }
    return minValue;
}

int GerMaxNumber (int [] array)
{
    int maxValue = 0;
    for (int i = 0; i < array.Length; i++)
    {
        maxValue = array[i] > maxValue ? array[i] : maxValue;
    }
    return maxValue;
}

int GetDifferenceNumber (int minValue, int maxValue)
{
    int result = maxValue - minValue;
    return result;
}

int [] mass = GetRandomeArray();
System.Console.WriteLine(string.Join(" ",mass));

int min = GerMinNumber(mass);
System.Console.WriteLine(min);

int max = GerMaxNumber(mass);
System.Console.WriteLine(max);

int result = GetDifferenceNumber(min, max);
System.Console.WriteLine(string.Join(" ",result));