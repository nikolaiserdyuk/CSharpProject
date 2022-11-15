// Задание 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = new Random().Next(1, 101);
int b = new Random().Next(1, 101);
int c = new Random().Next(1, 101);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное из трех чисел = ");
Console.WriteLine(max);