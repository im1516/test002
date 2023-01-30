// Лекция 7 Задача 1: Рекурсия факториала.

// итерративный способ. 

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// int Factorial (int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *=i;
//     return result;
// }
// Console.WriteLine(Factorial(n));


// Рекурсивный способ.

// int Factorial (int n)
// {
//     if (n == 0) return 1;
//     else return n* Factorial(n-1);
// }
// Console.WriteLine(Factorial(10));

// семинар 7


// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-10, 11);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3} \t");
//         Console.WriteLine();
//     }
// }



// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// int m = 3;
// int n = 4;

// int[,] array = new int[m, n];
// FillArray(array);
// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} \t");
//         Console.WriteLine();
//     }
// }



// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4



// int rows = 5;
// int cols = 5;
// int[,] array = new int[rows, cols];
// FillArray(array);
// EditArray(array);
// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = 5;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j]} \t");
//         Console.WriteLine();
//     }
// }

// void EditArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             if (i % 2 != 0 && j % 2 != 0) array[i, j] = array[i, j] * array[i, j];
// }


// Задача 51: Задайте двумерный квадратный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12
// найдите сумму элементов обратной диагонали



// int rows = 3;
// int cols = 3;
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// EditArray(array);
// SecondEditArray(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 9);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// void EditArray(int[,] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             if (i == j)
//                 summ = summ + array[i, j];


//     Console.WriteLine($"Сумма диагонали равна:{summ}");
// }

// void SecondEditArray(int[,] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         summ = summ + array[i, array.GetLength(0) - i - 1];


//     Console.WriteLine($"Сумма второй диагонали равна:{summ}");
// }


// Задача HARD SORT необязательная. Считается за три обязательных**
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int m = 3;
// int n = 4;
// double[,] array = new double[m, n];
// FillArray(array);
// PrintArray(array);

// void FillArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//            array[i,j] = Convert.ToDouble(new Random().Next(-111,111))/10;

// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j], 4} \t");
//         Console.WriteLine();
//     }
// }


// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int n = 3;
// int m = 4;
// int[,] array = new int[m, n];
// FillArray(array);
// PrintArray(array);
// PrintIndex(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 11);

// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],4} \t");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// // void PrintIndex(int[,] array, string value)
// // {
// //     for (int i = 0; i < array.GetLength(0); i++)

// //         for (int j = 0; j < array.GetLength(1); j++)

// //             if (array[i, j] == x) Console.WriteLine($"Индекс введеннго числа:{(i, j)}");


// // }


// void PrintIndex(int[,] array)
// {
//     bool find = false;
//     for (int i = 0; i < array.GetLength(0); i++)
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (x == array[i,j])
//         {
//             find = true; Console.WriteLine($"Индекс введеннго числа:{(i, j)}");
//             break;
//         }

//     }
//     Console.WriteLine (find);


// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = 4;
int cols = 4;
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
AverageSumm(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 9);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}

void AverageSumm(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = (summ + array[j,i]);
        }
        summ = summ / rows;
        Console.WriteLine($"Сумма столбцов равна:{summ}");
    }
    Console.WriteLine();

}



