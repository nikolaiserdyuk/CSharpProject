Console.WriteLine("Введите порядковый номер дня недели: ");
int date = Convert.ToInt32(Console.ReadLine());
if( 5 < date && date < 8)
{
    Console.WriteLine("Ура! Выходной!");
}
else if(0 < date && date < 6)
{
    Console.WriteLine("Этот день не выходной ;( ");
}
else
{
    Console.WriteLine("Таких дней недели не существует");
}