// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[] Arr = new int[8];
// CreateArr(Arr);
// PrintArr(Arr);
// SwapNumber(Arr);


// void CreateArr(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 9);
//     }
// }

// void SwapNumber(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] *-1; 
//         Console.Write($"{array[i]} ");  
//     }
//     Console.WriteLine();

// }

// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }





// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Введите число 1");
// int x = Convert.ToInt32(Console.ReadLine());


// int[] Arr = new int[8];
// CreateArr(Arr);
// SearchNum(Arr);
// PrintArr(Arr);

// void CreateArr(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 7);
//     }
// }

// void SearchNum(int[] array)
// {
//     bool find = false;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (x == array[i])
//         {
//             find = true;
//             break;
//         }

//     }
//     Console.WriteLine(find );

// }

// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }


// Задача 35: Задайте одномерный массив из 12 случайных чисел из промежутка (-100,100). Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 12
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int[] Arr = new int[12];
// CreateArr(Arr);
// PrintArr(Arr);
// DiapasonNumber(Arr);

// void CreateArr(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
// }


// void DiapasonNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 9 && array[i] < 100) count++;
//     }
//     Console.WriteLine(count);

// }

// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }



// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


//--------



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] Arr = new int[8];
// CreateArr(Arr);
// PrintArr(Arr);
// EvenNumbers(Arr);

// void CreateArr(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 999);
//     }
// }

// void EvenNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             ++count;
//     }
//     Console.WriteLine($"В массиве {count} четных числа.");
// }

// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



// int[] Arr = new int[4];
// CreateArr(Arr);
// PrintArr(Arr);
// SummNoEvenPos(Arr);

// void CreateArr(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 20);
//     }
// }

// void SummNoEvenPos(int[] array)
// {

//     int arrayN = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//             arrayN = arrayN + array[i];
//     }
//     Console.WriteLine($"Сумма чисел на нечетных индексах = {arrayN}.");
// }

// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] Arr = { 1.7, 23.3, 34.6, 0.7, 1.9, 2.5, 7.1, 0.5, 3.9, 5.2 };
PrintArr(Arr);
SummNoEvenPos(Arr);

void SummNoEvenPos(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
        else diff = max - min;
    }
    Console.WriteLine($"Разница минимального и максимального числа = {diff}");
}

void PrintArr(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}