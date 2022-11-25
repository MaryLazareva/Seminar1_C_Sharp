int Num(int n)
{
    Console.WriteLine($"Our number: {n}");
    int ost = n % 10;
    n = n / 100;
    int num = n * 10 + ost;
    return num;
}

Console.WriteLine(Num(new Random().Next(100,1000)));