void Numbers(int m, int n)
{
    if (m > n) return;

    if (m % 2 == 0) 
    {   
        Console.Write($" {m} ");
        Numbers(m + 2, n);
    }
    else
    {
        m += 1;
        Console.Write($" {m} ");
        Numbers(m + 2, n);
    }           
}
Console.WriteLine("Enter Numbers: ");
Numbers(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));