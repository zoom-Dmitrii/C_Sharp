Console.Clear();
Console.WriteLine("введите первое число");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
double m = Convert.ToInt32(Console.ReadLine());
if (n * n == m){
    Console.WriteLine("Число m - квадрат числа n");
}
else{
    Console.WriteLine("Число m - не являестя квадратом числа n");
}