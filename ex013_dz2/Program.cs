// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int x = new Random().Next(10,100);
// Console.WriteLine($"Сгенерированое число {x}");
// int x1 = x / 10;
// int x2 = x % 10;
// if (x1>x2) Console.WriteLine (x1);
// else if (x1<x2) Console.WriteLine (x2);
// else Console.WriteLine ("Одинкаовые числа");




int x = new Random().Next(100,1000);
Console.WriteLine($"Сгенерированое число {x}");
int x1 = x / 100;
int x2 = x % 100;
int x3 = x % 10;
int x4 = (x2-x3) / 10;

Console.WriteLine($"Число посередине:{x4}");

//