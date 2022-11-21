Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int n =  -num;
while(n<=num)
{
    Console.Write($"{n} ");
    n +=1;
}
