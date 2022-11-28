void Tabl(int n)
{
    int count = 1;
    while (count <= n)
        {
            if (count == n)
            {
                double kvadrat = Math.Pow(count,2);
                
                Console.Write($"{kvadrat}");
            }
            else
            {
                double kvadrat = Math.Pow(count,2);
                
                Console.Write($"{kvadrat}, ");
            }
            
            count +=1;
        }


}
Console.WriteLine("Введите число:");
Tabl(int.Parse(Console.ReadLine()));