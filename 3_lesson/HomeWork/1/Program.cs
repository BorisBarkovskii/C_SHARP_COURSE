// Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно палиндромом.

string Palindrome (int n)
{
    int num = 10000;
    if (n > 100000 || n < 10000)
        return "Число не явялется пятизначным";
    else
        while (num > 1)
        {
            if (n/num % 10 != n % 10)
                return "Нет";
            n /= 10;
            num /= 100;
        }
        return "Да";
}

Console.WriteLine(Palindrome(int.Parse(Console.ReadLine())));
