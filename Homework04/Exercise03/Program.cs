// напишите программу которая задает массив из 8 элементов
// и выводит их на экран (числа берем любые)


int[] array = new int[8];

int[] Massive(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;    
}

Massive(array);
Console.WriteLine($"Массив: {String.Join(" ", array)}");