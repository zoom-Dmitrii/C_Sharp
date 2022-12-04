Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine()),  maxArray = 0, minArray = 1001;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++) {
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
     if (array[i] > maxArray)
        maxArray = array[i];

    if (array[i] < minArray)
        minArray = array[i];

}
Console.WriteLine($"[{string.Join(", ", array)}]");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == maxArray)
        array[i] = minArray;
}
Console.WriteLine($"[{string.Join(", ", array)}]");

