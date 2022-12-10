Console.Clear();
int n1 = 0;
while (n1 < 100 || n1 > 999) {
    Console.WriteLine("введите трехзначное число");
    n1 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine((n1 / 10) %10);