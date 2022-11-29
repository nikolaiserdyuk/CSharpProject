// напишите цикл, который принимает на вход два числа (А и Б) 
// и возводит число А в натуральную степень Б.
// 3, 5 = 243 (3 В ПЯТОЙ)

Console.WriteLine("Введите число А: ");
double num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int degree = int.Parse(Console.ReadLine()!);
Console.WriteLine($"цикл вовзводит число {num} в {degree} степень в следующем виде - {GetDegree(num, degree)}");


double GetDegree(double num, int degree)
{
    double total = 1;
    for(int i = 1; i <= degree; i++)
        {
	    total = total * num;	 
        }
    return total;
}