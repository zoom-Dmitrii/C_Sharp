Console.Clear();
Console.Write("Задайте число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вывод натуральных чисел до заданного числа");
Console.WriteLine(PrintNumbers(n));

string PrintNumbers(int end)
{
    if (end == 1)
    {
       // Console.WriteLine(1);
        return "1";
    }
    string s = PrintNumbers(end - 1) + ' ' + end.ToString();
    // Console.WriteLine(s);
    return s;
}