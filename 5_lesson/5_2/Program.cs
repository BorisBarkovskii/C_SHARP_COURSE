// Задайте массив. Напишите программу, которая определяет, присутствует ли
// заданное число в массиве.
void Print(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
int[] Mass(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 100);
    return array;
}
string Search(int[] array, int num)
{
    for(int i = 0; i< array.Length; i++)
    {
        if(num == array[i])
            return "Да";
    }
    return "Нет";
}
int[] array_1 = Mass(int.Parse(Console.ReadLine()));
Print(array_1);
Console.WriteLine(Search(array_1, int.Parse(Console.ReadLine())));