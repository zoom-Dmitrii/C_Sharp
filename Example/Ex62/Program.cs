

void InputMatrix(int[,] matrix)
{
    int count = 0;
    int row = matrix.GetLength(0) - 1;
    int col = matrix.GetLength(1) - 1;
    int r1 = 0, c1 = 0;
    while (col != 0 || row != 0) { 
    for (int j = c1; j <= col; j++)
    {
        matrix[r1, j] = count;
        count++;
    }
    r1 ++;
    for (int j = r1; j <= row; j++)
    {
        matrix[j, row] = count;
        count++;
    }
    col --;
    for (int j = col; j >= c1; j--)
    {
        matrix[row, j] = count;
        count++;
    }
    row--;
    for (int j = row; j >= r1; j--)
    {
        matrix[j, c1] = count;
        count++;
    }
    c1 ++;
    }
    Console.WriteLine();
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

Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Заполнение массива спиралью");
InputMatrix(matrix);
OutputMatrix(matrix);