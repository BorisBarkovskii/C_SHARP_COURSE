// 2. Задайте одномерный массив, заполненный случайными числами.
//    Найдите сумму элементов, стоящих на нечётных позициях. 

void Print(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)    
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

int[] Massiv(int size, int from, int to)
{
    int[] array = new int[size];

    for (int i = 1; i < size; i++)    
        array[i] = new Random().Next(from, to);
    
    return array;
}

int Sum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i += 2)    
        count += array[i];
    
    return count;
}

int[] array_1 = Massiv(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(array_1);
Console.WriteLine(Sum(array_1));

