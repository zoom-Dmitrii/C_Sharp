Console.Clear();
Console.WriteLine("Введите числа через Enter, последнее 0");
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
Console.WriteLine($"Второе максимальное число: {maxSecond}");
