// 3. Задайте двумерный массив из целых чисел.
//    Найдите среднее арифметическое элементов в каждом столбце.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
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

void ArithmeticMean(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double res;

    for (int j = 0; j < column; j++)
    {
        res = 0;
        for (int i = 0; i < row; i++) res += arr[i, j];
        Console.Write($"{Math.Round(res / row, 2)}; ");
    }
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);

ArithmeticMean(arr_1);

