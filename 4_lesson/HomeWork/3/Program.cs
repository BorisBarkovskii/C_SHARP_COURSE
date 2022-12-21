// 3. Напишите программу, которая задаёт массив из 8 элементов
//    случайными числами и выводит их на экран. 

void Print(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] EightMass(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 100);
    return array;
}

int[] array_1 = EightMass(int.Parse(Console.ReadLine()));
Print(array_1);
int[] array_2 = EightMass(int.Parse(Console.ReadLine()));
Print(array_2);
