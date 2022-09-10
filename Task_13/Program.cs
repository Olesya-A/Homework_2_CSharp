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

// Console.Write("Input any integer number: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 100)
// {
//    while (number / 10 >= 100)
//     {
//         number = number / 10;
//     }
//    int remainder = number % 10;
//    Console.WriteLine($"{remainder}");
// }
// else 
//     {
//         Console.WriteLine("There is no third digit");
//    }