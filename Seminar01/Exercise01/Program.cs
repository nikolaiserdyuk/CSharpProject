// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя)

// Вариант 1

Console.WriteLine("Введите целое число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a * a;
Console.WriteLine($"Квадрат числа {a} = {b}");

// Вариант 2

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int sqr1 = Convert.ToInt32(Math.Pow(a, 2));
Console.WriteLine($"Квадрат числа {a} = {sqr1}");
