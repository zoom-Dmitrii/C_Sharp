void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 101);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ArrangeMatrix(int[,] matrix) {
           int temp = 0;
           int move = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    while (move != 1) {
                    move = 1;
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j-1];
            if (matrix[i, j] > matrix[i, j-1]) {
            matrix[i, j-1] = matrix[i, j]; 
            matrix[i, j] = temp;
            move = 0;
            }
        }
    }
    move = 0;
    }
    Console.WriteLine();
}

void OutputMatrix(int[,] matrix) {
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
ArrangeMatrix(matrix);
Console.WriteLine("Сортировка по строкам");
OutputMatrix(matrix);