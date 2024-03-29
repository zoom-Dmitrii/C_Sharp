﻿void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [-10, 10
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ColumnSum(int[,] matrix)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
            sum += matrix[i, j];
        sum /= matrix.GetLength(0);
        Console.Write($"{Math.Round(sum,2)} \t");
        sum = 0;
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Среднее арифметическое по столюцам");
ColumnSum(matrix);