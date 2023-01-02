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

int FindMaxLine(int[,] matrix)
{
    int sum = 0, min = 0, line = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (i == 0)
            min = sum;
        if (min > sum)
        {
            min = sum;
            line = i + 1;
        }
    }
    Console.WriteLine();
    return line;
}

Console.Clear();
int[] size;
int[,] matrix;
do 
{
Console.Write("Введите размеры вертикальной прямоугольной матрицы: ");
size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
matrix = new int[size[0], size[1]];
}
while (size[0] <= size[1]);
InputMatrix(matrix);
Console.WriteLine("Строка с наименьшей суммой элементов " + FindMaxLine(matrix));