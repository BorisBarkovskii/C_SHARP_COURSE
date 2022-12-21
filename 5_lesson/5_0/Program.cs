// Задайте массив из 12 элементов, заполненный случайными числами из
// промежутка [ -9, 9]. Найдите сумму отрцательных и положительных
// элементов массива. 
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных чисел равна 29, сумма отрицательных

void Print(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from,  int to)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(from, to);
    return array;
}

void SumPosNeg(int[] array)
{
    int pos, neg;
    pos = neg = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 0)
            pos += array[i];
        else
            neg += array[i];
    }
    Console.WriteLine($"Positive: {pos}, negative: {neg}");
}
int[] array_1 = MassNums(int.Parse(Console.ReadLine()),
                         int.Parse(Console.ReadLine()),
                         int.Parse(Console.ReadLine()));
Print(array_1);
SumPosNeg(array_1);