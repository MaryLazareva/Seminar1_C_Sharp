int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

void Stepen(double num1, double num2)
{
    double pr = 1;
    
    if (num2 >= 0)
    {
        for (int i = 0; i < num2; i++)
        {
            pr *= num1;
        }
        Console.WriteLine($"{num1}^{num2} = {pr}");
    }
    else
    {
        for (int i = 0; i < -(num2); i++)
        {
            pr *= 1/(num1);
           
        }
        Console.WriteLine($"{num1}^{num2} = {pr}");
    }   
       
}

int a = ReadNumber("Введите число A:");
int b = ReadNumber("Введите число B:");
Stepen(a,b);