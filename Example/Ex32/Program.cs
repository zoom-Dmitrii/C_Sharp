void InputArray (int [] array, int rasmer) {
for (int i = 0; i < array.Length; i++)
 array[i] = new Random().Next(rasmer * -1, rasmer + 1); // [-N, N]
Console.WriteLine($"[{string.Join(", ", array)}]");
}

void ReleaseArray (int [] array) {
for (int i = 0; i < array.Length; i++)
 array[i] *= -1;
Console.WriteLine($"[{string.Join(", ", array)}]");
}


Console.Clear();
Console.Write("Случайное заполнение массива от -N до N. Укажите размерность N: ");
int rasmer = Convert.ToInt32(Console.ReadLine());
int [] array = new int[rasmer*2+1];
InputArray(array, rasmer);
ReleaseArray(array);