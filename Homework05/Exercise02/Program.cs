// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] massive = GetArray(10);

int[] GetArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 101);
    }
    return result;
}
int SumOddElements = 0;
for(int i = 1; i < massive.Length; i += 2)
{
    SumOddElements += massive[i];
}


Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в одномерном массиве [{String.Join(", ", massive)}] равна {SumOddElements}");