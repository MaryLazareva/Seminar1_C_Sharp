int Sum(int n)
{
    int sum = 0;
    for (int i = 1; i <=n; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите число:");
Console.WriteLine(Sum(int.Parse(Console.ReadLine())));