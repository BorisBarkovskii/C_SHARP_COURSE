// Напишите программу, которая принимает на вход и выдает количество
// цифр в числе.

int NumbCount(int n)
{
    int count = 0;
    while (n > 0)
    {
        n = n/10;
        count++;
    }
    return count;
}
Console.WriteLine (NumbCount(int.Parse(Console.ReadLine())));