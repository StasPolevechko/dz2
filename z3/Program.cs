/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
int promrt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ??"";
    int result = Convert.ToInt32(value);
    return result;
}
bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekDay(int number)
{
    if (number >0 && number <=7)
    {
        return true;
    }
    Console.WriteLine("это не день недели");
    return false;
}
int weekDay =promrt("введите день недели: ");
if (ValidateWeekDay(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("наконецто выходной");
    }
    else
    {
        Console.WriteLine("придется идти на работу");
    }
}