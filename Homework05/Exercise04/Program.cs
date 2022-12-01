// Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементом массива.

int[] massive = GetArray(10, -10, 10);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

int max = massive[0];
int min = massive[0];

for(int i = 0; i < massive.Length; i++)
{
    if(massive[i] > max)
    {
        max = massive[i];
    }
    else if(massive[i] < min)
    {
        min = massive[i];
    }
}
Console.WriteLine($"Максимальное число одномерного массива [{String.Join(", ", massive)}] - '{max}', а минимальное - '{min}'.");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равняется {max - min}.");