Console.Clear();
Console.Write("Задайте число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вывод суммы цифр числа");
Console.WriteLine(PrintNumbers(n));

int PrintNumbers(int sum)
{
    if (sum == 0)
    {
        return 0;
    }
    int s = PrintNumbers(sum / 10) + sum % 10;
    return s;
}