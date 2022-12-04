Console.Clear();
Console.WriteLine("Введите номер четверти");
int n = Convert.ToInt32(Console.ReadLine());;

while (n < 1 || n > 4)
{
    Console.Write("Вы ошиблись!\nВведите ччисла 1 2 3 4 ");
    n = Convert.ToInt32(Console.ReadLine());;
}
if (n == 1)
    Console.WriteLine("x > 0 && y > 0");
else if (n == 2)
    Console.WriteLine("x < 0 && y > 0");
else if (n == 3)
    Console.WriteLine("x < 0 && y < 0");
else
    Console.WriteLine("x > 0 && y < 0");
