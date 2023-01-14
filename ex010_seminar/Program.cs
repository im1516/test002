Console.WriteLine("Является ли число 1 квадратом числа 2");
Console.WriteLine("Введите число 1");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int y = Convert.ToInt32(Console.ReadLine());

if (x==y*y)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
