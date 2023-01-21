// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4



// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());


// for(int x = 1;x <=N; x++ )

// Console.Write($" {x*x}");  


// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void ChkNbr(string num)
// {
//     if (num[0] == num[4] || num[1] == num[3])
//     {
//         Console.WriteLine($"Число: {num} - палиндром.");
//     }
//     else Console.WriteLine($"Число: {num} -не палиндром.");
// }

// if (number!.Length == 5)
// {
//     ChkNbr(number);
// }
// else Console.WriteLine($"Некорректный ввод");




// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("\n Задача 21");
// int x1 = Coord("x", "A");
// int y1 = Coord("y", "A");
// int z1 = Coord("z", "A");
// int x2 = Coord("x", "B");
// int y2 = Coord("y", "B");
// int z2 = Coord("z", "B");

// int Coord(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// }
// double EndLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

// Console.WriteLine($"Длина отрезка  {EndLength}");





// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());


// for(int x = 1;x <=N; x++ )

// Console.Write($" {(x*x)*x}"); 