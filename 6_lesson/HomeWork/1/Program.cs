// 1. Пользователь вводит с клавиатуры M чисел. 
//    Посчитайте, сколько чисел больше 0 ввёл пользователь. 


int Num()
{
    int count = 0;
    string word;

    while (true)
    {
        Console.Write("Введите число: ");
        word = Console.ReadLine();

        if (word == "") return count;
        else if (int.Parse(word) > 0) count += 1;        
    }
}

Console.Write(Num());

