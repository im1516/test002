// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int x = new Random().Next(10,100);
// Console.WriteLine($"Сгенерированое число {x}");
// int x1 = x / 10;
// int x2 = x % 10;
// if (x1>x2) Console.WriteLine (x1);
// else if (x1<x2) Console.WriteLine (x2);
// else Console.WriteLine ("Одинкаовые числа");




// int x = new Random().Next(100,1000);
// Console.WriteLine($"Сгенерированое число {x}");
// int x2 = x % 100;
// int x3 = x % 10;
// int x4 = (x2-x3) / 10;

// Console.WriteLine($"Число посередине:{x4}");





// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


// Console.WriteLine("Введите целое число 1:");
// int x = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите целое число 2:");
// int z = Convert.ToInt32( Console.ReadLine());

// int quad = x*x;
// int quad2 = z*z;

// if(z == quad)Console.WriteLine($"Число: {z} является квадратом числа: {x} ");
// else if (x == quad2) Console.WriteLine($"Число: {x} является квадратом числа: {z} ");
// else Console.WriteLine($"Число: {z} не является квадратом числа: {x} ");







// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5



// Console.WriteLine("Введите целое число:");
// int x = Convert.ToInt32( Console.ReadLine());
// int n=x;


// if(x<=99) Console.WriteLine("нет третьей цифры");
// else
// while(x>999)
// {
//     x=x/10;
// }
// int res = x % 10;
// Console.WriteLine($"{res} - третья цифра числа:{n}");









// Console.WriteLine("Введите порядковое число дня недели");
// int x = Convert.ToInt32( Console.ReadLine());
// if(x == 6 || x ==7) Console.WriteLine($"{x}-й день недели выходной");
// else if(x== 0||x>7) Console.WriteLine("Некорректный ввод");
// else if(x<6 ) Console.WriteLine($"{x}-й день недели рабочий");











// Задача необязательная 2: по желанию идет за 2 необязательных

// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".

// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.

// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 100 человек.



// int n = new Random().Next(1,100);

// if(n==1) Console.WriteLine($"В зале {n} программист");
// else if(n<5) Console.WriteLine($"В зале {n} программиста");
// else Console.WriteLine($"В зале {n} программистов");


//таблица умножения

// for(int i=2; i<=10; i++ )
// {
//     for (int j=2; j<=10; j++) Console.WriteLine($"{i}x{j}={i*j}");
//     Console.WriteLine();
// }



// string text = "цыувцыувй вфыаафыафы фваывафывфыв dfasf asdfasfasf asfasfasf fasfasaf";


// string Replace(string text,char oldValue, char newValue)
// {
//     string result = string.Empty;

//     int length = text.Length;
//     for (int i=0; i<length; i++)
//     {
//         if(text[i]== oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;

// }
// string newText = Replace(text,'ы', '@');
// Console.WriteLine(newText);





// int[] arr = { 1, 23, 34, 55, 1, 2, 7, 0, 3, 5 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SortArr(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPos = i;
//         for (int j = i; j < array.Length; j++)
//         {
//             if (array[j] < array[minPos]) minPos = j;
//         }
//         int temp = array[i];
//         array[i] = array[minPos];
//         array[minPos] = temp;
//     }

// }

// PrintArray(arr);
// SortArr(arr);
// PrintArray(arr);




// int[] arr = { 1, 23, 34, 55, 1, 2, 7, 0, 3, 5 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SortArr(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int maxPos = i;
//         for (int j = i; j < array.Length; j++)
//         {
//             if (array[j] > array[maxPos]) maxPos = j;
//         }
//         int temp = array[i];
//         array[i] = array[maxPos];
//         array[maxPos] = temp;
//     }

// }

// PrintArray(arr);
// SortArr(arr);
// PrintArray(arr);




//  Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0) Console.WriteLine("Это четверть № 1");
// else if (x > 0 && y < 0) Console.WriteLine("Это четверть № 4");
// else if (x < 0 && y < 0) Console.WriteLine("Это четверть № 3");
// else if (x < 0 && y > 0) Console.WriteLine("Это четверть № 2");
// else Console.WriteLine("Точка лежит на оси");


