string Polindrom(int n)
{ 
    int num = n / 10000;
    int num1 = n % 10;
    if (num == num1)
    {
        n = (n - num * 10000)/10;
        num = n / 100;
        num1 = n % 10;
        if (num == num1)
            return "Полиндром";
        else
            return "Не полиндром";
    }   
    else
        return "Не полиндром";    
}

Console.WriteLine("Введите число:");
Console.WriteLine(Polindrom(int.Parse(Console.ReadLine())));
