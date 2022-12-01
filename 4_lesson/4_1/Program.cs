int Num(int n)
{
    string num = n.ToString();
    int dlina = num.Length;
    return dlina;
}

Console.WriteLine("Введите число:");
Console.WriteLine(Num(int.Parse(Console.ReadLine())));

