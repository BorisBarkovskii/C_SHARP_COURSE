// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.
string Num(int num)
{
    if((-1000 < num && num < -99) || (num < 1000 && num > 99))
        return $"{num/ 10 % 10}";
    return "Число не трехнозначное.";
}
Console.WriteLine(Num(int.Parse(Console.ReadLine())));
