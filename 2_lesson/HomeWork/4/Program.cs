// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
void Day(int num)
{
    string text = "Не выходной.";
    
    if(num == 7 || num == 6) text = "Выходной.";
    Console.WriteLine($"{num} -> {text}");
}

Day(int.Parse(Console.ReadLine()));
