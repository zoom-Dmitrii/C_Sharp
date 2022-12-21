Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), x1 = 1, x2 = 0, x = 0;
for (int i = 0; i < n; i++)
{
x2 = x1;
x1 = x;
Console.Write($"{x} ");
x = x1 + x2;
} 