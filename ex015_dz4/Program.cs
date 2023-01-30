// string[,] arr = new string[3, 5];

//String.Empty;
// arr[0,0] arr[0,1] arr[0,2] arr[0,3] arr[0,4] 
// arr[1,0] arr[1,1] arr[1,2] arr[1,3] arr[1,4] 
// arr[2,0] arr[2,1] arr[2,2] arr[2,3] arr[2,4] 

// int[,] arr = new int[3, 5];

// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 5; j++)

//         Console.Write($"{arr[i, j]} ");
//     Console.WriteLine();
// }



// int[,] array = new int[3, 5];

// void PrintArray(int[,] arr)
// {

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)

//             Console.Write($"{arr[i, j]} ");
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)

//             arr[i, j] = new Random().Next(1, 9);
//     }
// }

// PrintArray(array);
// FillArray(array);
// Console.WriteLine();
// PrintArray(array);

// int Factorial(int N)
// {
//     if (N == 1) return 1;
//     else return N * Factorial(N - 1);
// }
// for(int i = 1; i<30; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }



// int Fibonachi(int F)
// {
//     if(F == 1 || F== 2) return 1;
//     else return Fibonachi(F-1) + Fibonachi(F-2);
// }
// for(int i = 1; i<50; i++)
// {
//     Console.WriteLine($"{i}! = {Fibonachi(i)}");
// }





// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// try
// {
//     Console.WriteLine("Введите целое число");
//     int N = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Сумма чисел от 1 до {N} равна {Summ(N)}");
// }
// catch
// {
//     Console.WriteLine("Некорректный ввод");
// }
//     int Summ(int N)
//     {
//         int sum = 0;
//         for (int i = 1; i <= N; i++)
//             sum += i;
//         return sum;

//     }



// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Console.WriteLine("Введите число");
// double N = Convert.ToDouble(Console.ReadLine());
// int x = 0; // введение перемнной, показывающей общее число цифр (разрядов) в числе

// for (int i = 1; ((N * i) % 1) != 0; i = i * 10) // цикл, вычисляющий кол-во знаков после запятой
// {
//     x += 1;
// }
// for (int i = 1; i < N; i = i * 10) // цикл, показывающий разрядность целого числа
// {
//     x += 1;
// }
// Console.WriteLine(x);

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите целое число");
// int N = Convert.ToInt32(Console.ReadLine());
// int x = 1;
// for (int i = 1; i <= N; i++)
// {
//     x = x * i;
// }
// Console.WriteLine(x);


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// void Ran(int[] col)
// {
// for (int index = 0; index < col.Length; index++)
// col[index] = new Random().Next(0, 2);
// }

// void Print(int[] col2)
// {
// foreach (int item in col2)
// Console.Write(item + " ");
// }

// bool ZZZ(int[] col3)
// {
// int a = 0;
// int b = 0;
// for (int index = 0; index < col3.Length; index++)
// {
// if (col3[index] == 1) a = a + 1;
// else b = b + 1;
// }
// if (a > b) return true;
// else return false;
// }


// int [] array = new int[8];
// Ran(array);
// Print(array);
// Console.WriteLine(ZZZ(array));




// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// Console.WriteLine("Введите число 1");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 2");
// int y = Convert.ToInt32(Console.ReadLine());
// Degree(x, y);

// void Degree(int x, int y)
// {
//     int z = 1;
//     for (int i = 1; i <= y; i++)
//     {
//         z = z * x;
//     }
//     Console.WriteLine($"{x} в {y}-й степени равно {z}");
// }





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// Console.WriteLine("Введите целое число ");
// int x = Convert.ToInt32(Console.ReadLine());
// Degree(x);

// void Degree(int x)
// {
//     int z = 0;
//     for (int i = 1; i <= x; i++)
//     {
//         z += x % 10; 
//         x /= 10; 
//     }
//     Console.WriteLine($"сумма чисел равна {z}");
// }



// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

// int[] Arr = new int[8];
// Console.WriteLine("Введите числа");
// CreateArr(Arr);
// PrintArr(Arr);

// void CreateArr(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }

// }
// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

