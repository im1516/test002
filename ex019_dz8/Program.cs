// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int rows = 3;
// int cols = 3;
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// EditArray(array);
// PrintArray(array);

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
//     int temp;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         temp = array[array.GetLength(1) - 1, j];
//         array[array.GetLength(1) - 1, j] = array[0, j];
//         array[0, j] = temp;
//     }
// }




// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести сообщение для пользователя.


// Console.Write("Введите количество строк: ");
// int numRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int numCols = Convert.ToInt32(Console.ReadLine());

// if (numRows != numCols) { Console.WriteLine("Заменить строки на столбцы невозможно"); return; }
// int[,] array = new int[numRows, numCols];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine("Массив после замены строк:");
// NewArray(array);
// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],2} \t");
//         Console.WriteLine();
//     }
// }

// void NewArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = i; j < array.GetLength(1); j++)
//         {
//             (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
//         }
// }


// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


// Console.Write("Введите количество строк: ");
// int numRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int numCols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[numRows, numCols];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// CountArray(array);
// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],2} \t");
//         Console.WriteLine();
//     }
// }
// void CountArray(int[,] array)
// {
//     int[] countarray = new int[10];

//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             countarray[array[i,j]]++;


//     for (int x = 0; x < 10; x++) 
//     {
//        if (countarray[x] != 0)
//        Console.WriteLine($" Число {x} встречается {countarray[x]}");
//     }
// }


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int rows = 3;
// int cols = 4;
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// EditArray(array);
// PrintArray(array);

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
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int z = 0; z < array.GetLength(1) - 1; z++)
//             {
//                 if (array[i, z] < array[i, z + 1]) 
//                 {
//                     int temp = 0;
//                     temp = array[i, z];
//                     array[i, z] = array[i, z + 1];
//                     array[i, z + 1] = temp;
//                 }
//             }
//         }
// }




// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int rows = 4;
// int[,] array = new int[rows, rows];
// FillArray(array);
// PrintArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }
// Console.WriteLine($"\n{minSumLine+1}-я - строкa с минимальной суммой: ({sumLine})");

// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
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


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int rows = 2;
// int[,] array = new int[rows, rows];

// int[,] firstMartrix = new int[rows, rows];
// FillArray(firstMartrix);
// Console.WriteLine($" Первая матрица:");
// PrintArray(firstMartrix);

// int[,] secomdMartrix = new int[rows, rows];
// FillArray(secomdMartrix);
// Console.WriteLine($" Вторая матрица:");
// PrintArray(secomdMartrix);

// int[,] resultMatrix = new int[rows, rows];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// PrintArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < firstMartrix.GetLength(1); k++)
//             {
//                 sum += firstMartrix[i, k] * secomdMartrix[k, j];
//             }
//             resultMatrix[i, j] = sum;
//         }
//     }
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
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


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int rows = 3;
// Console.WriteLine($"");

// int[,,] array3D = new int[rows, rows, rows];
// FillArray(array3D);
// PrintArray(array3D);

// void PrintArray(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]} = ({i} {j} {k}), ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,,] array3D)
// {
//     int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//     int number;
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);
//         number = temp[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 99);
//                     j = 0;
//                     number = temp[i];
//                 }
//                 number = temp[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array3D.GetLength(0); x++)
//     {
//         for (int y = 0; y < array3D.GetLength(1); y++)
//         {
//             for (int z = 0; z < array3D.GetLength(2); z++)
//             {
//                 array3D[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int n = 4;
// int[,] SpMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;
// PrintArray(SpMatrix);

// while (temp <= SpMatrix.GetLength(0) * SpMatrix.GetLength(1))
// {
//     SpMatrix[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < SpMatrix.GetLength(1) - 1)
//         j++;
//     else if (i < j && i + j >= SpMatrix.GetLength(0) - 1)
//         i++;
//     else if (i >= j && i + j > SpMatrix.GetLength(1) - 1)
//         j--;
//     else
//         i--;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] / 10 <= 0)
//                 Console.Write($" {array[i, j]} ");

//             else Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }