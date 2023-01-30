// Задача: напишите программу, которая на вход принимает 3 числа и проверяет , может ли существовать треугольник со сторонами данной длины.

// Console.WriteLine("Введите число 1");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 2");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 3");
// int z = Convert.ToInt32(Console.ReadLine());


// if (x+y>z && x+z>y && z+y>x) Console.WriteLine("Треугольник с таким соотношением сторон существует");
// else Console.WriteLine("Треугольник с таким соотношением сторон не существует");




// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// Console.WriteLine("Введите число 1");
// int num = Convert.ToInt32(Console.ReadLine());
// Binary(num);

// void Binary(int n)
// {
//     string array = string.Empty;
//     while (n > 0)
//     {
//         // if (n % 2 == 0) array = "0" + array;
//         // else array = "1" + array;
//         array = $"{n%2}" + array;
//         n = n / 2;
//     }
//     Console.WriteLine(array);

// }
// Binary(num);



// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// Console.WriteLine("Введите число фибоначчи");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// FillArray(array);
// PrintArray(array);

// void FillArray(int[] array)
// {
// array[0] = 0;
// array[1] = 1;
// for (int i = 2; i < N; i++)
// {
// array[i] = array[i - 1] + array[i - 2];
// }
// }
// void PrintArray(int[] mas)
// {
// for (int i = 0; i < mas.Length; i++)
// Console.Write($"{mas[i]} ");
// Console.WriteLine();
//}



// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите длину массива");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] Arr = new int[M];
// CreateArr(Arr);
// PrintArr(Arr);
// Mass(Arr);

// void CreateArr(int[] arrayA)
// {
//     for (int i = 0; i < M; i++)
//     {
//         Console.WriteLine($"Число {i + 1} массива");
//         arrayA[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine("Созданный массив:");
// }
// void Mass(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     Console.Write($"Количество чисел больше нуля = {count} ");
// }
// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"Прямые пересекутся в точке координат X: {x}, Y: {y}");
