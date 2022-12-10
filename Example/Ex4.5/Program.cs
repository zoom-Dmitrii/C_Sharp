void f(ref int a)
{
    a += 5;
}


Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
f(ref a);
Console.WriteLine(a);
/*
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
f(ref a);
Console.WriteLine(a);

*/