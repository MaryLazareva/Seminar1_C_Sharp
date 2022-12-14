void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($"{Math.Round(arr[i, j],2), 6} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column, double from, double to)
{
    double[,] arr = new double[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {    for (int j = 0; j < column; j++)
        {
            arr[i, j] = rnd.NextDouble() * (to - from) + from;
        }
    }
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

double[,] arr_1 = MassNums(row, column,
                        double.Parse(Console.ReadLine()),
                        double.Parse(Console.ReadLine()));
Print(arr_1);