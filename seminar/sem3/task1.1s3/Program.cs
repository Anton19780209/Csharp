// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

int[] CreateArray(int n, int min, int max) // метод создать массив
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
    System.Console.WriteLine();
}

int[] SingInvert(int[] array) // метод измнить знак
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

System.Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, min, max);
PrintArray(arr);
PrintArray(SingInvert(arr));




