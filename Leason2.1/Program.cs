//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

FindNumber();

void FindNumber()
{
    int number = new Random().Next(1, 10000);
}
int FindThreeNumber(int a)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третей цифры нет");
        return false;
    }
    return true;
}

int number = FindNumber("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(FindThreeNumber(number));
}