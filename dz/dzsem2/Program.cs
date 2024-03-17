// Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно 7 и 23.

System.Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 7 == 0 && n % 23 == 0)
{
    System.Console.WriteLine($"{n} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"{n} не кратно 7 и 23");
}