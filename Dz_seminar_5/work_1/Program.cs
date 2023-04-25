// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetRandomeArray(int lenght = 5, int minValue = 100, int maxValue = 1000)   
{
    int [] array = new int [lenght];                                            
    for (int i = 0; i < lenght; i++)                                            
    {
        array[i] = new Random().Next(minValue, maxValue);                       
    }
    return array;                                                               
}

int ShowNumber (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count += 1;
    }
    return count;
}

int [] mass = GetRandomeArray();
System.Console.WriteLine(string.Join(" ",mass));

int number = ShowNumber(mass);
System.Console.WriteLine(number);
