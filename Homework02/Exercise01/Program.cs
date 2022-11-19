// Вариант 1.

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000) 
{
	int seconditem = (number / 10) % 10;
	Console.WriteLine($"Второй цифрой числа {number} является {seconditem}");
}
else
{
	Console.WriteLine("Введено не трехзначное число");
}

// Вариант 2.

int num = new Random().Next(1, 1111);
string Numbers = num.ToString();
int n = Numbers.Length;
if(n == 3)
{
	Console.WriteLine($"Второй цифрой числа {num} является {Numbers[1]}");
}
else
{
	Console.WriteLine($"Введено не трехзначное число {num}");
}