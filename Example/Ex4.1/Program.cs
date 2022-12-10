Console.WriteLine("Введите количество кустов, от 3 до 1000");
int n = 0;
while (n <3 || n > 1000)
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
string[] input = new string[0];
while (input.Length != array.Length){
Console.WriteLine("Введите количество ягод на каждом кусте, от 1 до 1000");
//Console.WriteLine("Ели количество ягод-кустов превысит количество введенных кустов - они не учтутся, от 3 до 1000");
input = Console.ReadLine().Split(" ");
}

for (int i = 0; i < n; i++)
    array[i] = int.Parse(input[i].ToString());

int maxSumma = 0;
for (int i = 1; i < array.Length - 1; i++)
{
    int sum = array[i - 1] + array[i] + array[i + 1];
    if (sum > maxSumma)
        maxSumma = sum;
}
if (array[0] + array[1] + array[array.Length - 1] > maxSumma)
    maxSumma = array[0] + array[1] + array[array.Length - 1];

if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSumma)
    maxSumma = array[array.Length - 1] + array[array.Length - 2] + array[0];

Console.WriteLine($"Максимальное количество ягод на трех соседних кустах: {maxSumma}");
