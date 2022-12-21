void InputArray (int [] array) {
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1,11); // [1, 10]
}

void ReleaseArray (int [] array) {
for (int i = 0; i < array.Length / 2; i++) {
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
}Console.Clear();
Console.Write("Укажите размер массива: ");
int [] array = new int[Convert.ToInt32(Console.ReadLine())];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}]");