void InputArray (int [] array) {
for (int i = 0; i < array.Length; i++)
 array[i] = new Random().Next(0, 501); // [0, 500]
}

int ReleaseArray (int [] array) {
    int count = 0;
for (int i = 0; i < array.Length; i++)
 if (array[i] >= 10 && array[i] <=99) 
 ++count;
 return count; 
}


Console.Clear();
Console.WriteLine("Размер массива из 123 элементов");
Console.WriteLine();
int [] array = new int[122];
InputArray(array);
Console.Write($"Число элементов от 10 до 99 внутри массива: {ReleaseArray(array)}");
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}]");