// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

//Задание 3. Работа в сессионных залах
//Семинар 2. Простые алгоритмы на C#
//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли первое число
//кратным второму. Если первое число некратно
//второму, то программа выводит остаток от деления.
//Примеры
//14, 5 => нет, 4
//16, 8 => да
//4, 3 => нет, 1
//
void MinusSecond(int num)//456
{
    int ed = num % 10;//6
    int sot = num / 100;//4
    System.Console.WriteLine($"{num} -> {sot * 10 + ed}");
}

int MinusSecondInt(int num)//456
{
    int ed = num % 10;//6
    int sot = num / 100;//4
    //System.Console.WriteLine($"{num} -> {sot * 10 + ed}");
    int result = sot * 10 + ed;
    return result;
}

int SecondToThird(int num)
{
    int ed = num % 10;
    int dec = num / 10 % 10;
    int res = 1;
    for (int i = 0; i < ed; i++)//2^4 = 2 * 2 * 2 * 2
    {
        res = res * dec;
    }
    return res;
}

bool IsTheeDigit(int num)
{
    if (num >= 100 && num <= 999)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void FirstDivSecond(int a, int b)
{
    if(a % b == 0)
    {
        System.Console.WriteLine($"{a} кратно {b}");
    }
    else
    {
        System.Console.WriteLine($"{a} не кратно {b}, остаток {a % b}");
    }
}

System.Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

FirstDivSecond(num1, num2);
