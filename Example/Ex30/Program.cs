Console.Clear();
int n = 8;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0,2); // [0, 2]

Console.WriteLine($"[{string.Join(", ", array)}]");