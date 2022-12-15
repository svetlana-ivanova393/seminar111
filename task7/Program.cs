// Напишите программу, которая принимает на входтрёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a % 10);

// или

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a >= 100 && a < 1000)
// {
// Console.Write("Последняя цифра:");
// Console.Write (a % 10);
// }
// else 
// {
//     Console.Write("Введено не 3-хзначное число");
// }
