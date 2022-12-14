string [] movement (string [] input2, int move2) {
string temp = string.Empty;
while ( move2 != 0) {
if (move2 < 0) {
    int i = 0; 
    temp = input2[i];
    for (i = 0; i < input2.Length - 1; i++){
        input2[i] = input2[i+1];
    }
input2[i] = temp;
++move2;
i = 0;
}
else {
int i = input2.Length - 1;
temp = input2[i];
    for (i = input2.Length - 1; i > 0; i--){
        input2[i] = input2[i-1];
    }
input2[i] = temp;
--move2;
i = input2.Length-1;
}; 
}
    return input2;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
string [] input = new string[Convert.ToInt32(Console.ReadLine())];
Console.WriteLine("Введите элементы массива через пробел: ");
input = Console.ReadLine().Split(" ");
Console.Write("Сдвиг на число: ");
int move = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"[{string.Join(" ", movement(input, move))}]");
