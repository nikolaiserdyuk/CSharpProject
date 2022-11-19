// Вариант 1. 
Console.WriteLine("Введите число: ");
string Numbers = Console.ReadLine()!;
int n = Numbers.Length;
if(2 < n && n < 6)
{
    Console.WriteLine($"Третья цифра числа {Numbers} является {Numbers[2]}");
}
else
{
    if(n > 5)
    {
        Console.WriteLine("Введенное число больше 99999");
    }
    if(n < 5)
    {
        Console.WriteLine($"У числа {Numbers} третьей цифры нет");
    }
}


// Вариант 2.
int num = new Random().Next(1, 100000);
if(99 < num && num < 100000)
{
    string number = num.ToString();
    Console.WriteLine($"Третьей цифрой числа {number} является {number[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
