// Задача №2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = new Random().Next(-10, 11);
int b = new Random().Next(-10, 11);
int max = a;
int min = b;
if(a > b) 
{
    max = a; min = b;
    Console.Write("Большее = ");
    Console.WriteLine(max);
    Console.Write("Меньшее = ");
    Console.WriteLine(min);
}
else if(b > a) 
{
    max = b; min = a;
    Console.Write("Большее = ");
    Console.WriteLine(max);
    Console.Write("Меньшее = ");
    Console.WriteLine(min);
}
else
{
    Console.WriteLine("Числа равны");
}