Console.Clear();
Console.WriteLine("введите первое число");
double n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
double n2 = Convert.ToInt32(Console.ReadLine());
if (n2 * n2 == n1){
    Console.WriteLine($"Число {n2} является квадрвтом числа " + n1);    
}
else {
Console.WriteLine($"Число {n2} не является квадрвтом числа " + n1);
}
