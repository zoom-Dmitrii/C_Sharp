Console.Clear();
Console.WriteLine("введите число");
double n = Convert.ToInt32(Console.ReadLine());
if ((n % 7 == 0) && ( n % 23 == 0)){ 
    Console.WriteLine("Число кратно 7 и 23");
} else {
    Console.WriteLine("Число не кратно одновременно 7 и 23");
}