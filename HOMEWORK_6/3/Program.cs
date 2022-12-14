void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

void SredneeArifm(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {   
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
            sum += arr[i, j];
        
        double srednArifm = Math.Round(sum / arr.GetLength(0), 2);
        Console.Write($"{srednArifm} ");
    }
    Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a range of numbers:");
int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine("Average of each column: ");
SredneeArifm(arr_1);