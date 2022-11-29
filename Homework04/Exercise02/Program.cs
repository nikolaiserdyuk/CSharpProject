// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
// 452 = 11
// 82 = 10
// 9012 = 12


int num = new Random().Next(10, 9999);
GetSize(num);

int GetSize(int number)
{
    int size = 0;
    while(number > 0)
    {
        number /= 10;
        size++;
    }
    return size;
}
int SumNumbers(int size)
{
    int sum = 0;
    for(int i = 1; i <= size; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
Console.WriteLine($"Сумма всех цифр числа {num} равна {SumNumbers(num)}");

