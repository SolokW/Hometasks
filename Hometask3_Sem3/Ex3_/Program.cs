//Задача 23

// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// * В большинстве задач методов будет несколько
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int a = 1; a <= N;)
{
   Console.WriteLine($"{a}^3 = {a*a*a}");
    a ++; 
}