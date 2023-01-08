int[] InputMatrix(int[,] matrix)
{
    int minNum = 0;
    int[] colrow = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 101);
            if (i == 0 && j == 0)
                minNum = matrix[i, j];
            if (minNum > matrix[i, j])
            {
                minNum = matrix[i, j];
                colrow[0] = i;
                colrow[1] = j;
            }
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Наименьший элемент: {minNum}");
    return colrow;
}

void OutputMatrix(int[,] matrix, int[] colrow)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != colrow[0]){
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (j != colrow[1])
                    Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] colrow = InputMatrix(matrix);
Console.WriteLine($"Удаление Столбца {colrow[1]+1} и Строки {colrow[0]+1} с наименшим элементом на пересечении");
OutputMatrix(matrix, colrow);