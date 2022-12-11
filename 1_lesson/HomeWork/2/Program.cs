// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

int a_1 = int.Parse(Console.ReadLine());
int a_2 = int.Parse(Console.ReadLine());
int a_3 = int.Parse(Console.ReadLine());

if (a_1 < a_2);
{
    a_1 = a_2;
}
if (a_1 < a_3);
{
    a_1 = a_3;
}
Console.WriteLine($"Число {a_1} максимальное.");
