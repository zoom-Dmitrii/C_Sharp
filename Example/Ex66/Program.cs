Console.Clear();
Console.Write("Задайте начальное число M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте конечное число N: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вывод суммы чисел от M до N");
Console.WriteLine($"{Summ(n, m)}");

int Summ(int start, int end)
{
    if (end == start)
    {
        return start;
    }
    return (end + Summ(start, end-1));
}