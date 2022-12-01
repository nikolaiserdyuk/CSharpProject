// // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] massive = GetArray(15, 100, 999);

int[] GetArray(int size, int min, int max)
{   
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
 int counter = 0;
foreach(int i in massive)
{
    if(i % 2 == 0)
    {
        counter++;
    }
}

Console.WriteLine($"Количество четных чисел в массиве [{String.Join(", ", massive)} равняется {counter}]");