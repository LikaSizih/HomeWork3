int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outline = string.Empty;
    while (i <= numberN)
    {
        Console.Write("{0,7}", Math.Pow(i,pow));
        i++;
    }
    Console.WriteLine();
}

int num = ReadData("Введите число N: ");

LineNumbers(num,1);
LineNumbers(num,3);