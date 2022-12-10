Console.Clear();
Console.WriteLine("Введите число");
string number = Console.ReadLine(), revers = string.Empty;
//int n = Convert.ToInt32(number);
for (int i = number.Length-1; i >= 0; i--) {
revers += number[i];
}
if (revers.Equals(number)) 
Console.Write("Число полиндром");
else Console.Write("Число НЕ полиндром");