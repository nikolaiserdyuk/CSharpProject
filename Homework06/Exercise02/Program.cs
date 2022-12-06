// Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)
// в промежутке от 0 до 100, а на выходе выводит этот же массив, отсортированный по возрастанию 
// от меньшего к большему

int n = new Random().Next(7, 12);

int[] massive = GetMassive(n);

int[] GetMassive(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 101);
    }
    return result;
}

Console.WriteLine($"[{String.Join(", ", massive)}]");

int temp;
for (int i = 0; i < massive.Length - 1; i++)
{
    for (int j = i + 1; j < massive.Length; j++)
    {
        if (massive[i] > massive[j])
        {
            temp = massive[i];
            massive[i] = massive[j];
            massive[j] = temp;
        }
    }
}
 

Console.WriteLine($"[{String.Join(", ", massive)}]");
