﻿Console.Clear();
Console.WriteLine("Введите координату Х:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
double y = Convert.ToDouble(Console.ReadLine());
while (x == 0)
{
    Console.Write("Вы ошиблись!\nВведите координату X: ");
    x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0)
{
    Console.Write("Вы ошиблись!\nВведите координату Y: ");
    y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");
