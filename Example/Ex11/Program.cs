Console.Clear();
int number = new Random().Next(100,1000);
Console.WriteLine($"Сгенерированное число {number}");
Console.WriteLine((number - number % 100) / 10 + number % 10);