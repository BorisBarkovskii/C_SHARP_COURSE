// Задайте значение N. Напишите программу, 
// которая выведет все четные натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

void EvenNumbers(int M, int N)
{
    if (M > N) return;

    if (M % 2 == 0) 
    {   
        Console.Write($" {M} ");
        EvenNumbers(M + 2, N);
    }
    else
    {
        M += 1;
        Console.Write($" {M} ");
        EvenNumbers(M + 2, N);
    }           
}
Console.WriteLine("Введите значения: ");
EvenNumbers(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));