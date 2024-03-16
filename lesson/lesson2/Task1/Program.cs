
// int[] arr = new int[5];
// arr[0] = 5;
// arr[1] = 7;
// arr[2] = 8;
// arr[3] = 2;
// arr[4] = 4;
// System.Console.WriteLine(arr[0]);
// System.Console.WriteLine(arr[1]);
// System.Console.WriteLine(arr[2]);
// System.Console.WriteLine(arr[3]);
// System.Console.WriteLine(arr[4]);
// 
// int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
// 
// int[] arr3 = { 1, 2, 3, 4, 5 };
 // arr = { 1, 2, 3, 4, 5 };


// int n = 10;
// int[] arr = new int[n];
// int i = 0;
// 
// while (i < arr.Length)
// {
//     arr[i] = i + 1;
//     //System.Console.Write(i);
//     //System.Console.Write(' ');
//     System.Console.Write($"{arr[i]} ");
//     i = i + 1;
// }


//int n = 10;
int[] array = [4, 5, 9, 3, 6, 8, 2, 6, 4, 3];
int i = 0;

while (i < array.Length)
{  
    if (array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    
    }
    i = i + 1;
}