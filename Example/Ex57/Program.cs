bool FindNumArray(int[] array, int number)
{
    foreach (int element in array)
        if (element == number)
        {
            return false;
        }

    return true;
}

int InputMatrix(int[,] matrix, int[] array)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 101);
            Console.Write($"{matrix[i, j]} \t");
            if (FindNumArray(array, matrix[i, j]))
            {
                array[count] = matrix[i, j];
                count++;
            }
        }
        Console.WriteLine();
    }
    return count;
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


void ReleaseMatrix(int[,] matrix, int[] array, int count)
{
    for (int k = 0; k < count; k++)
    {
        int countNumber = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {   
                if (array[k] == matrix[i,j])
                countNumber ++;
            }
        }
        Console.WriteLine($"{array[k]} встречается {countNumber} раз");
    }
}

Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] array = new int[size[0] * size[1]];
int count = InputMatrix(matrix, array);
Console.WriteLine("Сколько раз повторяются значения в двумерном массиве");
ReleaseMatrix(matrix, array, count);