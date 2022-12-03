Console.Clear();
Console.WriteLine("введите первое число");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
double m = Convert.ToInt32(Console.ReadLine());
if (n % m == 0){
    Console.WriteLine("Число кратно");
}
else{
    Console.WriteLine($"Число не кратно остаток {n % m}");
}
