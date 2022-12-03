Console.Clear();
Console.WriteLine("введите первое число");
double n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
double n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
double n3 = Convert.ToInt32(Console.ReadLine());
if ((n1 > n2) && (n1 > n3)){
    Console.WriteLine($"Первое число максимальное. max {n1} ");
}
else{
    if ((n2 > n1) && (n2 > n3)) {
        Console.WriteLine($"Второе число максимальное. max {n2} ");
    }
    else {
        Console.WriteLine($"Третье число максимальное. max {n3} ");
    }
}