﻿void InputMatrix(int[,] matrix)
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

void OutputMatrix(int[,] matrix) {
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


int [,] ReleaseMatrix(int [,] matrix) {
 for (int j = 0; j < matrix.GetLength(1); j++) {
    int temp = matrix[0,j];
    matrix[0,j] = matrix[matrix.GetLength(0) - 1,j];
    matrix[matrix.GetLength(0) - 1,j] = temp;
 }
 return matrix;
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Меняем первую и последнюю строку");
OutputMatrix(ReleaseMatrix(matrix));