// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

System.Console.Write("Input ferst number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a)
{
    System.Console.WriteLine($"{a} is quard of {b}");
}
else
{
    System.Console.WriteLine($"{a} is not quard of {b}");
}
