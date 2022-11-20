//Нужно написать программу которая выводит случайное число 
//из отрезка от 10 до 99 и показывает наибольшую цифру этого числа

int number = new Random().Next(10, 100);
int a = number / 10;
int b = number % 10;
if(a > b)
{
	Console.WriteLine($"Наибольшая цифра числа {number} является {a}");
}
else if(b > a)
{
	Console.WriteLine($"Наибольшая цифра числа {number} является {b}");
}
else
{
	Console.WriteLine($"Цифры числа {number} равны друг другу");
} 