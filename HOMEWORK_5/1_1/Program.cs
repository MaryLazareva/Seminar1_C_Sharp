void Num(string n)
{
    int count = 0;
    while (n != "")
    {
      if (int.Parse(n) > 0)
        count++; 

      n = Console.ReadLine();
    }
    Console.WriteLine(count);
}
Num(Console.ReadLine());