// Задание 1. Совместная работа
// Семинар 3. Массивы
// 15 мин
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array) // метод вывести массиы
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
bool FindNumber(int num, int[] array) // метод задать число
{
    foreach (int item in array)
    {
        if (item == num)
        {
            return true;
        }
    }
    return false;
}

System.Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, min, max);
PrintArray(arr);
System.Console.WriteLine();
System.Console.Write("Input num wants to find: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindNumber(num, arr));

