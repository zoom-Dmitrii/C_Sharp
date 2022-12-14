void InputArray (int [] array) {
for (int i = 0; i < array.Length; i++)
 array[i] = new Random().Next(0, 11); // [0, 10]
}

void ReleaseArray (int [] array, int number) {
for (int i = 0; i < array.Length; i++)
 if (array[i] == number) { 
 Console.WriteLine("Вы угадали, есть такое число в массиве!");
 return;
}
    Console.WriteLine("Вы НЕ угадали, такого числа в массиве нет"); 
}


Console.Clear();
Console.Write("Укажите размер массива: ");
int [] array = new int[Convert.ToInt32(Console.ReadLine())];
InputArray(array);
Console.Write("Укажите число от 0 до 10: ");
int number = Convert.ToInt32(Console.ReadLine());
ReleaseArray(array, number);
Console.WriteLine($"[{string.Join(", ", array)}]");