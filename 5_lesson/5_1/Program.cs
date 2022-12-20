// Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательны, и наоборот.

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
void Massiv(int[] array_1)
{
    for (int i = 0; i < array_1.Length; i++)
        array_1[i] = -array_1[i];

}
int[] array_1 = Mass(int.Parse(Console.ReadLine()));
Print(array_1);
Massiv(array_1);
Print(array_1);