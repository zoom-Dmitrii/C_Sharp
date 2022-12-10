Console.Clear();
int n1 = 0;
while (n1 < 1 || n1 > 7) {
    Console.WriteLine("введите день недели числом от 1 до 7");
    n1 = Convert.ToInt32(Console.ReadLine());
}
if (n1 == 7 || n1 == 6) {
    Console.WriteLine("Вы ввели выходной день");
}
