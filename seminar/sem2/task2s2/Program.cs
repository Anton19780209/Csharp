// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// int SecondToThird(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10 % 10;
//     int res = (int)Math.Pow(dec,ed);
//     return res;
// }

// System.Console.Write("Input three-digit number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int result = SecondToThird (a);
// System.Console.WriteLine (result);


int SecondToThird(int num)
{
    if(IsTheeDigit(num))
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
    else
    {
        return 0;
    }
}
System.Console.Write("Input three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = SecondToThird (a);
System.Console.WriteLine (result);

// Отдельный метод на трехзачное число

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

