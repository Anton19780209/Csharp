int n = 5;
int[] array = { 2, 8, 5, 16, 7 };
int i = 0;
int max = array[i];

while (i < n)
{
    if (array[i] > max)
    {
       max = array[i];
    }
    i = i + 1;
}
System.Console.WriteLine(max);

max = array[0];
for (int j = 1; j < n; j++)
{
    if (array[j] > max)
    {
       max = array[j];
    }
}
System.Console.WriteLine(max);

max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
       max = e;
    }
}
System.Console.WriteLine(max);