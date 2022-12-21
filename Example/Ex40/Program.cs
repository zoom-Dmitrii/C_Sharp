String TestSide(int[] sizeSide)
{
    if (sizeSide[0] < sizeSide[1] + sizeSide[2])
        if (sizeSide[1] < sizeSide[0] + sizeSide[2])
            if (sizeSide[2] < sizeSide[0] + sizeSide[1])
                return "являются сторонами треугольника";
    return "не являются сторонами треугольника";
}

Console.Clear();
Console.Write("Введите длины трех сторон треугольника: ");
int[] sizeSide = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"Введенные длины {TestSide(sizeSide)}");