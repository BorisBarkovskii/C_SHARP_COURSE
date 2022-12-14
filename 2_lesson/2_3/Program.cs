// Напишите программу, которая принимает на вход число и проеряет,
// кратно ли оно одновременно 7 и 23.
string divisible (int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        return "Делимое.";
    else
        return "Неделимое.";
}
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(divisible(number));
