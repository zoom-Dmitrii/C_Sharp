Console.Clear();
Console.WriteLine("введите число");
int n1 = Convert.ToInt32(Console.ReadLine());
int nstart = 0;
if (n1 > 0) 
 nstart = (-1) * n1;
 else {
    nstart = n1;
    n1 = (-1) * n1;
 }
Console.WriteLine($"Целые числа в диапозоне от {nstart} до " + n1);
for(int i=nstart; i <= n1; i++) {
    Console.Write(" " + i + " ");
}