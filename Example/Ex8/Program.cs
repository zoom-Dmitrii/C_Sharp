Console.Clear();
Console.WriteLine("введите число");
double n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четные числа в диапозоне от 1 до {n1} ");
for(int i=1; i <= n1; i++) {
 if (i % 2 == 0){
    Console.Write(" " + i + " ");    
 }
}