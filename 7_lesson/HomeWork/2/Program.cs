// 2. Напишите программу, которая на вход принимает позиции элемента
//    в двумерном массиве, и возвращает значение этого элемента 
//    или же указание, что такого элемента нет.

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

string Element(int[,] arr, int f, int s)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (f > row || f <= 0 || s > column || s <= 0)
        return $"{f} {s} -> значение элемента отсутствует.";
    return $"arr[{f}, {s}] = {arr[f - 1, s - 1]} -> значение элемента.";
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);

Console.Write("Введите номер строки: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int second = int.Parse(Console.ReadLine());

Console.WriteLine(Element(arr_1, first, second));
