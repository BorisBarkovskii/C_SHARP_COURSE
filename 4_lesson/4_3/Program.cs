// Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и еденицами в случайном порядке.

void Massiv(int n)
{
    int[] array = new int [n];
    for (int i = 0; i < n; i++)
    {
        array [i] = new Random().Next(2);
        Console.WriteLine($"{array[i]} ");
    }
}
Console.WriteLine("Введите чсло: ");
Massiv(int.Parse(Console.ReadLine()));