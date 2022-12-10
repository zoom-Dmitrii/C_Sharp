Console.Clear();
Console.WriteLine("введите число");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Кубы чисел в диапозоне от 1 до {n1} ");
for(int i=1; i <= n1; i++) {
    Console.WriteLine($"Число {i}, куб " + Math.Pow(i,3));    
}