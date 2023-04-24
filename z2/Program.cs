/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.Write("введи число: ");
int number = int.Parse(Console.ReadLine() ?? "");
int thirdNumber(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

Console.WriteLine($" {number} -> {thirdNumber(number)} ");
