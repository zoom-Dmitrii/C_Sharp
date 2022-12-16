void InputArray (double [] array) {
for (int i = 0; i < array.Length; i++)
array[i] = Math.Round(new Random().NextDouble() + new Random().Next(1,100), 2); // [1, 99]
Console.WriteLine($"[{string.Join(", ", array)}]");
}
double ReleaseArray (double [] array) {
double minNum = array[0], maxNum = array[0];
for (int i = 1; i < array.Length; i++) {
    if (array[i] < minNum) minNum = array[i];
    else  if (array[i] > maxNum) maxNum = array[i];
}
return minNum + maxNum;
}

Console.Clear();
Console.Write("Укажите размер массива: ");
double [] array = new double[Convert.ToInt32(Console.ReadLine())];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма минимального и максимального элемента массива: {ReleaseArray(array)} ");