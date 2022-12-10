int f(int a, int b=10)
{
    if (a > b)
        return a;
    return b;
}

// return возвращает значение либо в консоль, либо в переменную
// return завершает работу функции
// Сколько аргументов мы передаем, столько и принимаем. НО!!!
Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a));
