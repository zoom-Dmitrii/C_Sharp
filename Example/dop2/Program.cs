Console.Clear();
int n = int.Parse(Console.ReadLine());
int maxFirst = n, maxSecond = -1;
while (n != 0)
{
    n = int.Parse(Console.ReadLine());
    if (maxFirst < n)
    {
        maxSecond = maxFirst;
        maxFirst = n;
    }
    else if (maxSecond < n)
        maxSecond = n;
}
Console.WriteLine(maxSecond);
