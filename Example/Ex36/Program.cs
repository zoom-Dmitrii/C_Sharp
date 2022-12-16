void InputArray (int [] array) {
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-99, 100); // [-99, 99]
Console.WriteLine($"[{string.Join(", ", array)}]");
}
int ReleaseArray (int [] array) {
    int count = 0; 
for (int i = 1; i < array.Length; i +=2) {
    count += array[i]; 
}
return count;
}

Console.Clear();
Console.Write("Укажите размер массива: ");
int [] array = new int[Convert.ToInt32(Console.ReadLine())];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {ReleaseArray(array)} ");