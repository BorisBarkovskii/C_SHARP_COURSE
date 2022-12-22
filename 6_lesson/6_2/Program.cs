// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.

string Bin(int num)
{
    string res = "";

    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }
    return res;
}

Console.WriteLine(Bin(int.Parse(Console.ReadLine())));
