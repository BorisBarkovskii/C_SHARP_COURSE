// Напишите программу, которая будет выдавать название дня недели по 
// заданному номеру ( 3 -> Среда, 5-> Пятница).
Console.WriteLine("Write a number:");
int d = int.Parse(Console.ReadLine());
if (d == 1)
{
    Console.WriteLine("Monday");
}
else if (d == 2)
{
    Console.WriteLine("Tuesday");
}
else if (d == 3)
{
    Console.WriteLine("Wednesday");
}
else if (d== 4)
{
    Console.WriteLine("Thursday");
}
else if (d==5)
{
    Console.WriteLine("Friday");
}
else if (d==6)
{
    Console.WriteLine("Saturday");
}
else if (d==7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Error");
}