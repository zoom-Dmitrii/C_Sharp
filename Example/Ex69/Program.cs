Console.Clear();
Console.Write("Задайте число X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вывод числа X в степени Y");
Console.WriteLine($"{Pow(x, y)}");

int Pow(int num, int runk)
{
    if (runk == 0)
    {
        return 1;
    }
    return (num * Pow(num, runk - 1));
}