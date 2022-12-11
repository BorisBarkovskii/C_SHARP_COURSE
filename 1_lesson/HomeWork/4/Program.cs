// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
int num = int.Parse(Console.ReadLine());
int a = 2;
while (a<= num)
{
    Console.Write($"{a}");
    a += 2;
}
