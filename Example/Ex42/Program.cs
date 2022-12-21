
Console.Clear();
Console.Write("Введите десятичное число: ");
String binary = string.Empty;
int num = Convert.ToInt32(Console.ReadLine());
while (num != 0)
{
   binary = binary.Insert(0,Convert.ToString(num % 2));
   num = num / 2; 
} 
Console.Write($"Двоичное представление: {binary}");