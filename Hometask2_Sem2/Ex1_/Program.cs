// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//(1)
// int a = 456;
// int b = 782;
// int c = 918;

// int valA = a / 10;
// int valB = b / 10;
// int valC = c / 10;

// int valAA = valA % 10;
// int valBB = valB % 10;
// int valCC = valC % 10;


// Console.WriteLine($"{a} -> {valAA}");
// Console.WriteLine($"{b} -> {valBB}");
// Console.WriteLine($"{c} -> {valCC}");

//(2)
int HOP(int value)
{
    int val = value / 10;
    int end = val % 10;
    return end;
}
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} - > ");
System.Console.WriteLine(HOP(num));

