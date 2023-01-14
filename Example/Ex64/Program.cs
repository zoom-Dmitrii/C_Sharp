Console.Clear();
Console.Write("Задайте начальное число M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте конечное число N: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вывод натуральных чисел от N до M");
Console.WriteLine(PrintNumbers(n, m));

string PrintNumbers(int start, int end)
{
    if (end == start)
    {
        return start.ToString();
    }
    return PrintNumbers(start + 1, end) + ' ' + start.ToString();
}