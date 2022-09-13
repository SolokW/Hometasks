// Напишите метод, который принимает на вход шестизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// строки использовать нельзя!


Console.WriteLine("Введите шестизначное число: ");

int num = Convert.ToInt32(Console.ReadLine());
// 123456

char[] hop = num.ToString().ToCharArray();
// Console.Write(hop);
int x = hop.Length - 1;

 for (int i = 0; i < hop.Length/2; i++)
        {
            // Console.Write(hop[x - i]);
            // Console.Write(hop[i]);

            if (hop[i] != hop[x-i])
            {
                Console.Write($"{num} -> нет");
                Environment.Exit(0);
            }
        }
Console.Write($"{num} -> да");
  


// int a = num;
// int b = num;
// int[] o = {};
// while (b>0)
// { 
//     a = b % 10;
//     b = b / 10;
//     Console.Write(a);

// }

// int mun = Convert.ToInt32(Console.ReadLine());
// int g = num - mun;
// Console.Write(g);


// if (mun == num) Console.WriteLine($"{num} -> да");
// else Console.WriteLine($"{num} -> нет");