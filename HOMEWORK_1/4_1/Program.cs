string Number(int n)
{
    if (n > 99)
    {   
        while (n > 1000)
        {
            n = n / 10;
        }   

        return $"Number is {n % 10}";
    }   
   
    else  
        return "not have third number";
}

Console.WriteLine("Input number:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Number(num));
