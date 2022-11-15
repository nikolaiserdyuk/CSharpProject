// Нужно написать программу которая на вход принимает 2 числа и проверяет является ли первое число квадратом второго.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if(a == b * b)
{
    Console.WriteLine($"Число {a} ялвяется квадратом числа {b}");
}
else
{
    Console.WriteLine($"Число {a} не является квадратом числа {b}");
}