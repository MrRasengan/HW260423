// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
if(number < 100 || number >= 1000 )
{
    Console.WriteLine("Выедено не трёхзначное число");
}
else
{
int FindNumber(int x)
{
    x = number / 10 % 10;
    return x;
}
Console.WriteLine("Вторая цифра этого числа: " + FindNumber(number));
}
