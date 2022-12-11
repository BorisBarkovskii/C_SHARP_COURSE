// Напишите программу вычисления модуля числа.
Console.Write("Write a number: ");
var a = Console.ReadLine();
int N = a == null ? 0 : int.Parse(a);
Console.WriteLine($"{Math.Abs(N)}");

