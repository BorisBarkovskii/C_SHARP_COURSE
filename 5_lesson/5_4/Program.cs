// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

void Print(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(from, to);
    return array;
}

int[] PairsNum(int[] array)
{
    int size = array.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_array = new int[flex_size];

    for (int i = 0; i < size / 2; i++)
        new_array[i] = array[i] * array[size - i - 1];

    if (new_array[flex_size - 1] == 0)
        new_array[flex_size - 1] = array[flex_size - 1];
    return new_array;
}

int[] array_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(array_1);
int[] array_1_new = PairsNum(array_1);
Print(array_1_new);

