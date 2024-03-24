// int[] Array = { 1, 81, 10, 62, 7, 62, 26, 51, 90, 72 };
// int i = 0;
// int count = 0;
// while (i < Array.Length)
// {

//        if (Array[i] >= 10 && Array[i] <= 90)
//     { count =  count + 1;
//     }
//     i = i + 1;
// }
// System.Console.WriteLine(count);

// int[] Array = { 1, 81, 10, 62, 7, 62, 26, 51, 90, 72 };
// int i = 0;
// int count = 0;
// while (i < Array.Length)
// {
//     if (Array[i] % 2 == 0)
//     {
//         count =  count + 1;
//     }
//     i = i + 1;
// }
// System.Console.WriteLine(count);

// double[] array = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };
// int i = 0;
// double max = 0;
// double min = array[0];
// while (i < array.Length)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     i = i + 1;
// }
// while (i < array.Length)
// {
//     if (array[i] < min)
//     {
//         min = array[i];
//     }
//     i = i + 1;
// }
// double difference = max - min;
// System.Console.WriteLine(difference);

// int[] CountItemsRange(int[] Array)
// {
//     int i = 0;
//     int count = 0;
//     while (i < Array.Length)
//     {

//        if (Array[i] >= 10 && Array[i] <= 90)
//         { 
//             count =  count + 1;
//         }
//         i = i + 1;
//     }
//     return CountItemsRange[];
// }

// int CountItems(int Count)
// {
//     int result = Count * Count;
//     return result;
// }
// int answer = CountItems(7);
// System.Console.WriteLine(answer);



int N = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= minRange && numbers[i] <= maxRange)
    {
        N++;
    }
}
return N;

int Count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= minRange && numbers[i] <= maxRange)
            {
                Count++;
            }
        }
        return Count;

        nt cnt = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= minRange && numbers[i] <= maxRange)
            {
                cnt++;
            }
        }
        return cnt;