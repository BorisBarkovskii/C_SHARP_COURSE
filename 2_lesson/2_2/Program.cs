// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе  число кратное первому.
// Если число 2  не кратно числу 1, то программа выводит
// остаток без деления. 
void Crat(int num,int num2)
{
    if (num % num2 == 0)
        Console.WriteLine("Кратно");
    else    
        Console.WriteLine($"Некратно, остаток = {num%num2}");
}

Console.WriteLine("Первое число:");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число:");
int second = int.Parse(Console.ReadLine());
Crat(first, second);
