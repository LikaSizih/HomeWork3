int InputIntNumber()
{
    while(true)
    {
        Console.WriteLine("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine() ?? "0");
        while(number > 999 && number < 100000)
        return number;
    }
} 
int num = InputIntNumber();

void Polindr()
{
    string chars = num.ToString();
    if(chars[0] == chars[4] && chars[1] == chars[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
Polindr();