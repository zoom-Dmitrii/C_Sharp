void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
        }
    }
}

void OutputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FindNum(int[,] matrix)
{
    Console.WriteLine("Поиск значений в матрице.");
    Console.WriteLine();
    int j = 1;
    while (j > 0)
    {
        Console.WriteLine("Введите индексы матрицы");
        int[] find = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        if (find[0] > matrix.GetLength(0)-1 || find[1] > matrix.GetLength(1)-1)
        {
            Console.WriteLine("Такой позиции в массиве нет");
            OutputMatrix(matrix);
            j = 0;
        }
        else
            Console.WriteLine($"Данные в выбранной ячейке {matrix[find[0], find[1]]}");
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
FindNum(matrix);