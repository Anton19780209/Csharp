
// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// void MinusSecond (int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     System.Console.WriteLine($"{num} -> {sot * 10 + ed}");
// }

// System.Console.Write("Input three-digit number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// MinusSecond(a);

// second metodate

int MinusSecondInt (int num)
{
    int ed = num % 10;
    int sot = num / 100;
    // System.Console.WriteLine($"{num} -> {sot * 10 + ed}");
    int result = sot * 10 + ed;
    return result;
}

System.Console.Write("Input three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int res = MinusSecondInt (a);
System.Console.WriteLine (res);

