// Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно 7 и 23.

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n % 7 == 0 && n % 23 == 0)
// {
//     System.Console.WriteLine($"{n} кратно 7 и 23");
// }
// else
// {
//     System.Console.WriteLine($"{n} не кратно 7 и 23");
// }


// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер координатной четверти плоскости, в которой находится эта точка.

// System.Console.Write("Input x: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input y: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > 0 && b > 0)
// {
//     System.Console.WriteLine($"1");
// }
// if (a > 0 && b < 0)
// {
//     System.Console.WriteLine($"2");
// }
// if (a < 0 && b > 0)
// {
//     System.Console.WriteLine($"4");
// }
// if (a < 0 && b < 0)
// {
//     System.Console.WriteLine($"3");
// }

// Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

// static void Main()
// {
//     System.Console.Write("Input two-digit number: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int firstDigit = number / 10;
//     int secondDigit = number % 10;
//     int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
//     Console.WriteLine(maxDigit);
// }


// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

void Main(int n)
{
    Console.Write("Введите натуральное число N: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (n < 10)
    {
        Console.WriteLine(n);
    }
    else
    {
        while (n > 0)
        {
            int currentDigit = n % 10;
            n /= 10;
            if (n > 0)
            {
                Console.Write(currentDigit + ",");
            }
            else
            {
                Console.WriteLine(currentDigit);
            }
        }
    }
}