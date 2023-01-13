Console.Clear();
Console.Write("Задайте начальное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте конечное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вывод натуральных чисел от начального до конечного числел");
Console.WriteLine(PrintNumbers(n, m));

string PrintNumbers(int start, int end)
{
    if (end == start)
    {
        return start.ToString();
    }
    string s = PrintNumbers(start, end - 1) + ' ' + end.ToString();
    return s;
}