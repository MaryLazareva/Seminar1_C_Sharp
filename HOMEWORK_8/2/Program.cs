int Summ(int m, int n)
{
    if (m > n) return 0;
    return Summ(m + 1, n) + m;
}

Console.WriteLine("Enter Numbers: ");
Console.WriteLine(Summ(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));