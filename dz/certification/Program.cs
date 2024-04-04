
// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// Console.WriteLine("Введите значение M:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение N:");
// int n = Convert.ToInt32(Console.ReadLine());
// PrintNumbersInRange(m, n);
// void PrintNumbersInRange(int m, int n)
// {
//     if (m <= n)
//     {
//         Console.Write(m);
//         PrintNumbersInRange(m + 1, n);
//     }
// }

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// int[] array = { 1, 2, 3, 4, 5 };
// PrintArrayReverse(array, array.Length - 1);
// void PrintArrayReverse(int[] array, int index)
// {
//     if (index >= 0)
//     {
//         Console.WriteLine(array[index]);
//         PrintArrayReverse(array, index - 1);
//     }
// }

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.WriteLine("Введите значение m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение n:");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = AckermannFunction(m, n);
// Console.WriteLine($"Значение функции Аккермана для m={m} и n={n} равно {result}");
// int AckermannFunction(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return AckermannFunction(m - 1, 1);
//     }
//     else
//     {
//         return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     }
// }