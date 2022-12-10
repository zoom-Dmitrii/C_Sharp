int f(int a, int b)
{
    int c = 1;
    while (b != 0) {
    c *= a;
    b--;
    }
    return c;
}
Console.Clear();
Console.WriteLine("Возведение числ A в степень B");
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b < 0) b *= -1;
Console.WriteLine($"Числ A в степени B: {f(a, b)}");