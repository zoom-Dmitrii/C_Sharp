Console.Clear();
Console.WriteLine("Координата первой точки:");
Console.WriteLine("Введите координату X1:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y1:");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Координата второй точки:");
Console.WriteLine("Введите координату X2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y2:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2)));
