// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

bool FindNumber(int num, int[] array)
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

int[] SingInvert(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}



int[] arr = CreateArray(size, min, max);
PrintArray(arr);
PrintArray(SingInvert(arr));




