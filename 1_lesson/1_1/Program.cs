// Напишите программму, которая на вход принимает два числа и проверяет
// является  ли первое  чмсло квадратом второго.
Console.WriteLine ("Write a number 1");
int num1 =  int.Parse(Console.ReadLine());
Console.WriteLine ("Write a number 2");
int num2 = int.Parse(Console.ReadLine ());
if(num2 == num1*num1)
{
    Console.WriteLine("Yes");
}
else
    Console.WriteLine("No");