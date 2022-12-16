void InputArray (int [] array) {
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000); // [100, 999]
Console.WriteLine($"[{string.Join(", ", array)}]");
}
int ReleaseArray (int [] array) {
    int count = 0; 
for (int i = 0; i < array.Length; i++) {
    if (array[i] % 2 == 0) count ++; 
}
return count;
}

Console.Clear();
Console.Write("Укажите размер массива: ");
int [] array = new int[Convert.ToInt32(Console.ReadLine())];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {ReleaseArray(array)} ");