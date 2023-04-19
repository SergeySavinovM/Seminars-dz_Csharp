 //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] ArrayNumber(int length)
{
    int [] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}
int [] RandomNumber1 = ArrayNumber(8);
string ArrayString = string.Join(",", RandomNumber1);
System.Console.WriteLine(ArrayString);
