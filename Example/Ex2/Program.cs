Console.Clear();
Console.WriteLine("введите первое число");
double n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
double n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2){
    Console.WriteLine($"Первое число больше второго. max {n1} ");
}
else{
    Console.WriteLine($"Второе число больше первого. max {n2} ");
}