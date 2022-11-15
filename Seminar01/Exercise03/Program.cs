// Показать последнюю цифру трехзначного числа 

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int number3 = number % 10;
Console.WriteLine($"Третья цифра трехзначного числа {number} - {number3}");