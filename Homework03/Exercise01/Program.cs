// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).
//14212 -> нет0
//12821 -> да
//23432 -> да

int num = new Random().Next(9999, 100000);
// проверка -->
//Console.WriteLine("Введите пятизначное число");
//int num = int.Parse(Console.ReadLine()!);
string Number = num.ToString();
if(Number[0] == Number[4] && Number[1] == Number[3])
{
    Console.WriteLine($"Число {num} является палиндромом");
}
else
{
    Console.WriteLine($"Число {num} не является палиндромом");
}