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

void OutputMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


int[,] ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
    return matrix;
}

Console.Clear();
int[] size;
int[,] matrix;
do
{
    Console.Write("Введите размеры квадратной матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    matrix = new int[size[0], size[1]];
}
while (size[0] != size[1]);
InputMatrix(matrix);
Console.WriteLine("Меняем строки на столбцы");
OutputMatrix(ReleaseMatrix(matrix));