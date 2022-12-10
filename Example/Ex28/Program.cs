Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine()), res = 1;
for (int i = 2; i <= n; i++ ) {
 res *= i;
}
Console.WriteLine(res);