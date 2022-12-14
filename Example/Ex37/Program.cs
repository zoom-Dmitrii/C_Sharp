void InputArray (int [] array) {
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 11); // [0, 10]
Console.WriteLine($"[{string.Join(", ", array)}]");
}

void ReleaseArray (int [] array) {
for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
Console.Write($"{array[i] * array[array.Length - 1- i]}, ");
    /*
    int [] array2;
    if (array.Length % 2 == 0) {
     array2 = new int [array.Length / 2];
     for (int i = 0; i < array.Length / 2; i++)
      array2[i] = array[i] * array[array.Length - 1- i];   
      return array2;
    }
     else {
      array2 = new int [array.Length / 2 + 1];   
      for (int i = 0; i <= array.Length / 2; i++)
        if (array.Length - 1- i == 0) 
          array2[i] = array[i] * 2;
        else
        array2[i] = array[i] * array[array.Length - 1- i];
      return array2;
     }
     */
}


Console.Clear();
Console.Write("Укажите размер массива: ");
int [] array = new int[Convert.ToInt32(Console.ReadLine())];
InputArray(array);
Console.WriteLine();
Console.WriteLine("Произведение парных чисел массива");
ReleaseArray(array);