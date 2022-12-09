void Points(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1)/(k1 - k2);

    double y = k1 * (b2 - b1)/(k1 - k2) + b1;

    Console.WriteLine($"({x};{y})");
}

Points(double.Parse(Console.ReadLine()),
       double.Parse(Console.ReadLine()),
       double.Parse(Console.ReadLine()),
       double.Parse(Console.ReadLine()));


