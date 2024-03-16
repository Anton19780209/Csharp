int a = 6;
int b = 8;
int c = 3;
int d = 1;
int e = 9;

int max = a;

if (b > a)
{
    max = b;
}
if (c > b)
{
    max = c;
}
if (d > c)
{
    max = d;
}
if (e > d)
{
    max = e;
}

System.Console.WriteLine(max);
