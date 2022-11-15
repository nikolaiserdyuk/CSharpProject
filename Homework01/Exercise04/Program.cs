// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int m = 1;
while(m < n + 1)
{
    if(m % 2 == 0)
        Console.Write($"{m} ");
        m++;   
}