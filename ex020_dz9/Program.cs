// посчитать сумму всех чисел от 1 до введенного N

// Console.WriteLine("Введите натуральное число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Summa(N));
// Console.WriteLine(SummaRec(N));


//обычный код
// int Summa(int N)
// {
// int sum=0;
// while (true)
// {
// if (N==0) break;
// sum=sum+N;
// N--;
// }
// return sum;
// }

// рекрусия
// int SummaRec(int N)
// {
// if (N==0) return 0;
// return N + SummaRec(N-1);
// }




// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// Console.WriteLine("Введите натуральное число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Rec(N));
// string Rec(int N)
// {
// if (N==1) return $"1";
// return  Rec(N-1) + $" {N}" ;
// }


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.WriteLine("Введите натуральное число");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите натуральное число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Rec(N));
// string Rec(int N)
// {
// if (M==N) return $"1";
// return  Rec(N-1) + $" {N}";
// }



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите натуральное число");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Rec(N));
// int Rec(int N)
// {
// if (M==N) return N;
// return  Rec(N-1) +  N;
// }


//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("Введите натуральное число N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(summ(N));

// int summ(int N)
// {
//     if (N < 1) return 0;
//     return (N % 10) + summ(N / 10);
// }


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.WriteLine("Введите натуральное число N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(AllNumber(N, M));

// int AllNumber(int N, int M)
// {
// if (M==0) return 1;
// return N * AllNumber(N, M - 1);
//}


// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите натуральное число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Rec(N));
// string Rec(int N)
// {
// if (N==1) return $"1";
// return  $"{N}," + Rec(N-1);
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.WriteLine("Введите натуральное число n");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число m");
// int m = Convert.ToInt32(Console.ReadLine());
// int Ackermann(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else
//         if ((n != 0) && (m == 0))
//         return Ackermann(n - 1, 1);
//     else
//         return Ackermann(n - 1, Ackermann(n, m - 1));
// }
// Console.WriteLine($"A(n,m)={Ackermann(n, m)}.");