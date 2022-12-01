int Proiz(int n)
{
    int pr = 1;
    for (int i = 1; i <=n; i++)
    {
        pr *= i;
    }
    return pr;
}

Console.WriteLine("Введите число:");
Console.WriteLine(Proiz(int.Parse(Console.ReadLine())));