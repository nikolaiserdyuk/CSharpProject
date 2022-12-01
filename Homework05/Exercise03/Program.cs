// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] massive = GetArray(5, -10, 10);
//int[] massive = GetArray(6, -10, 10);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

int[] MultiArray(int[] massive)
{
    int NewMassiveLength = massive.Length / 2;
    if(massive.Length % 2 != 0) NewMassiveLength++;

    int[] NewMassive = new int[NewMassiveLength];
    
    for(int i = 0; i < NewMassiveLength; i++)
        {
            NewMassive[i] = massive[i] * massive[massive.Length - i - 1];
        }
    if(massive.Length % 2 != 0)
    {
        NewMassive[NewMassiveLength - 1] = massive[massive.Length / 2];
    }
    return NewMassive;
}
Console.WriteLine($"Произведение пар чисел из одномерного массива [{String.Join(", ", massive)}] => [{String.Join(", ", MultiArray(massive))}]");