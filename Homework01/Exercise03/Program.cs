﻿// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a = new Random().Next(-100, 101);

if(a % 2 == 0)
{
    Console.Write(a);
    Console.WriteLine(": число является четным");
}
else
{
    Console.Write(a);
    Console.WriteLine(": число не является четным");
}
