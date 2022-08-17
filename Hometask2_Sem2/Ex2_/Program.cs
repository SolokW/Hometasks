// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// int HOP(int value)
// {
//     int a = value / 100;
//     int b = a % 10;
//     return b;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (HOP(num) == 0)
// {
//     Console.Write($"{num} -> Третьей цифры нет");
// }
// else
// {
//     Console.Write($"{num} - > ");
// System.Console.WriteLine(HOP(num));
// }

// Не могу понять, почему оно работает, но оно работает!
// 30 минут уже понять не могу, почему программа при вводе "123456" не выводит "124". Я же только от "3" избавился.

int HEY(int value)
{
    int a = value / 100;
    int b = a % 10;
    if (b == 0)
    {
        return a;
    }
    else
    {
        b = b % 10;
    }
    return b;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (HEY(num) == 0)
{
    Console.Write($"{num} -> Третьей цифры нет");
}
else
{
    Console.Write($"{num} - > ");
System.Console.WriteLine(HEY(num));
}
