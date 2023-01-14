Console.Clear();
Console.Write("Задайте первое число m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Функция Аккермана A(m,n): ");
Console.WriteLine($"{Ack(n, m)}");

int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Ack(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
    else
        return n + 1;
}