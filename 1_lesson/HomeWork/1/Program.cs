// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

int a_1 = int.Parse(Console.ReadLine());
int b_1 = int.Parse(Console.ReadLine());
if (a_1 > b_1)
{
    Console.WriteLine($"Число {a_1} больше числа {b_1}");
}
else if (a_1 == b_1)
{
    Console.Write($"Число {a_1} равно числу  {b_1}");
}
else
{
    Console.Write ($"Число {b_1} больше числа {a_1}");
}