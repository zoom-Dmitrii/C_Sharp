List<int> FindNum (int count) {
    List<int> countList = new List<int>();
    Boolean simpleNum = false; 
for (int i = 2; i <= count; i++) {
    simpleNum = true;
    for (int j = 2; j < i; j++) {
        if (i % j == 0) {
        simpleNum = false;
        break;
        }
    }
    if (simpleNum == true) countList.Add(i);
}
Console.WriteLine($"[{string.Join(" ", countList)}]");
return countList;
}

string FindSum (List<int> countList, int count) {
    for(int i = countList.Count-1; i != 0; i--) {
        for(int j = 0; j <= countList.Count-1; j++) {  
        if (countList[j] + countList[i] == count) {
//        Console.WriteLine(countList[j] + " " + countList[i]);
        return countList[j] + " " + countList[i];
        }
    }
    }
    return "Ответ неизвестен";
}

Console.Clear();
int count = 0;
while (count < 2 || count % 2 != 0) {
Console.Clear();
Console.Write("Введите четное число: ");
count = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(FindSum(FindNum(count), count));