//int n = 10;
int[] array = [4, 5, 9, -3, 6, 8, -2, 6, 4, 3];
int i = 0;

while (i < array.Length)
{  
    if (array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i = i + 1;
}