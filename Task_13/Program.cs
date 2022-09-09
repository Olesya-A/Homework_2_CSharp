// 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine($"Третья цифра числа = {input[2]}");
}