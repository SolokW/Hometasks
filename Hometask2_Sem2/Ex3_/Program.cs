// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Ведите день недели: ");
int index = Convert.ToInt32(Console.ReadLine());
int[] array = {1, 2, 3, 4, 5, 6, 7};

    if(index <=4)
    {
        Console.Write($" {index} -> no");
    }
    else
    {
        Console.Write($" {index} -> yes");
    }


