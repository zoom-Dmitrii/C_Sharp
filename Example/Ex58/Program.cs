void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void OutputMatrix(int[,] matrix, int[,] matrix2)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j] * matrix2[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры для двух двумерных массивов: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[,] matrix2 = new int[size[0], size[1]];
Console.WriteLine("Массив 1");
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Массив 2");
InputMatrix(matrix2);
Console.WriteLine("Вывод произведения двух массивов");
OutputMatrix(matrix, matrix2);