int InputArray (int [] array) {
    int countPositive = 0;
for (int i = 0; i < array.Length; i++)
 if (array[i] > 0)  ++countPositive;
return countPositive;
}

Console.Clear();
Console.WriteLine("Сколько чисел больше 0 \n Введите целые числа через пробел, завершение Enter: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"[{string.Join(", ", array)}]");
InputArray(array);
Console.WriteLine(InputArray(array));