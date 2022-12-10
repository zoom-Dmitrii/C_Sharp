Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int [] num = new int[Convert.ToInt32(Console.ReadLine())];
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < num.Length; i++){
num[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", num)}]");