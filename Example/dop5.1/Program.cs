void InputArray (int [] array) {
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1,32); // [1, 99]
Console.WriteLine($"[{string.Join(" ", array)}]");
}

void ReleaseArray (int [] array) {
    List<int> assessThree = new List<int>();
    List<int> assessFour = new List<int>();
for (int i = 0; i < array.Length; i++) {
    if (array[i] % 2 == 0) assessFour.Add(array[i]);
    else assessThree.Add(array[i]);
}
Console.WriteLine("-----");
Console.WriteLine($"[{string.Join(" ", assessFour)}]");
Console.WriteLine($"[{string.Join(" ", assessThree)}]");
if (assessThree.Count > assessFour.Count) 
Console.WriteLine("NO");
 else Console.WriteLine("YES");
}

Console.Clear();
int arrayCount = 0;
while (arrayCount < 1 || arrayCount > 100) {
Console.Write("Укажите количество оценок: ");
arrayCount = Convert.ToInt32(Console.ReadLine());
}
int [] array = new int[arrayCount];
InputArray(array);
Console.WriteLine();
Console.WriteLine("Вася получит 4 в конце четверти?");
ReleaseArray(array);