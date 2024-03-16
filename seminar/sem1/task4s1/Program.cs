// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

System.Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999) 
{
    int ed = num % 10;
    int sot = num / 100;
    System.Console.WriteLine($"{num} -> {ed + sot}");
}
else
{
    System.Console.Write("You Input not three-digit number");
}

// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81