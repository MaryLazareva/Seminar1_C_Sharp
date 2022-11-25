int Num(int n)
{
    Console.WriteLine($"Our number: {n}");
    n = n / 10;
    int ost = n % 10;
    return ost;
}

Console.WriteLine(Num(new Random().Next(100,1000)));
