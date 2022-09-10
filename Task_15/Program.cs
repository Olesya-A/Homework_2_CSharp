// 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int number = int.Parse(Console.ReadLine());

if (number > 7 || number < 1)
{
    Console.WriteLine("Такого дня недели нет");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Этот день является выходным");
}
else
{
    Console.WriteLine("Этот день НЕ является выходным");
}