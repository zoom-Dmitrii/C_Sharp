Console.Clear();
Console.WriteLine("введите число");
double n1 = Convert.ToInt32(Console.ReadLine());
if (n1 % 2 ==0){
    Console.WriteLine($"Число четное ");
}
else{
    Console.WriteLine($"Число нечетное ");
}