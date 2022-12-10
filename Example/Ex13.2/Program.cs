Console.Clear();
int n1 = 0;
    Console.WriteLine("введите трехзначное число");
    n1 = Convert.ToInt32(Console.ReadLine());
    if (n1 < 100) {
        Console.WriteLine("третьей цифры нет");
    } else {
          while (n1 >= 1000) n1 /= 10;
         Console.WriteLine(n1 % 10);
//Console.WriteLine((n1 / 10) %10);
    }

