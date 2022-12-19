// Напишите программу, которая прнимает на вхд число (N) и выдает таблицу
// квадратов чисел от 1 до N.

void Chet(int N)
{
    int i = 0;
    double pere;
    while (i <= N)
   {
        i += 1;
        pere = Math.Pow(i,2);
        Console.Write($"{pere},");
   }
}
Console.WriteLine("Введите число:");
int chislo = int.Parse(Console.ReadLine());
Chet(chislo);
