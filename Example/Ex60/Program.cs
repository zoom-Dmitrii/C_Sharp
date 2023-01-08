void InputMatrix(int[,,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = count;
                count++;
            }
        }
    }
      Console.WriteLine();
}

void OutputMatrix(int[,,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.WriteLine($"{matrix[i, j, k]} ({i}, {j}, {k})");
        }
    }
}

Console.Clear();
int[] size;
int[,,] matrix;
do
{
    Console.Write("Введите размеры трехмергой матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
while ((size[0] * size[1] * size[2]) > 80);
matrix = new int[size[0], size[1], size[2]];
InputMatrix(matrix);
Console.WriteLine("Вывод значений трехмерного массива с их индексами:");
OutputMatrix(matrix);