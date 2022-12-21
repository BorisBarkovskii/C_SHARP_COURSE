// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, знаения которых 
// лежат в отрезке [10,99].
void Print(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
int[] Mass(int size, int start, int last)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 100);
    return array;
}
int CountDiap(int[] array)
{
    int count = 0;
    for(int i = 0; i< array.Length; i++)
    {
            if (array[i] >= 10 && array[i] <=99)
            {   
                count++;  
            }
    }
    return count;
}
int[] array_1 = Mass(int.Parse(Console.ReadLine()),
                     int.Parse(Console.ReadLine()),
                     int.Parse(Console.ReadLine()));
Print(array_1);
Console.Write(CountDiap(array_1));