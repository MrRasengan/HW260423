// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine("Рандомное трёхзначное число:" + number);

int FindNumber(int x)
{
    x = number / 10 % 10;
    return x;
}
Console.WriteLine("Вторая цифра этого числа: " + FindNumber(number));