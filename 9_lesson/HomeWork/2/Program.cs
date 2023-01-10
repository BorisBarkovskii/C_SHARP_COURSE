// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum(int M, int N)
{
    if (M > N) return 0;
    return Sum(M + 1, N) + M;
}

Console.WriteLine("Введите значения: ");
Console.WriteLine(Sum(int.Parse(Console.ReadLine()), 
                      int.Parse(Console.ReadLine())));
