// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 0 || a >= 8)
{
    Console.Write("Такого дня не существует");
}
else
{
    if (a == 1) Console.Write("Понедельник");
    if (a == 2) Console.Write("Вторник");
    if (a == 3) Console.Write("Среда");
    if (a == 4) Console.Write("Четверг");
    if (a == 5) Console.Write("Пятница");
    if (a == 6) Console.Write("Суббота");
    if (a == 7) Console.Write("Воскресенье");
}

// Switch кейс
//
// int DayNumber = Convert.ToInt32(Console.ReadLine());
// switch (DayNumber)
// {
//     case 1:
// /       Console.Write("Введите число: ");

//         int a = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 - конвертируем в нужный нам тип - при вводе данных из консоли
//         int square = a * a;
//         Console.WriteLine("Квадрат числа равен " + square);
//         break;
//     case 2:
//         Console.WriteLine("Вторник");
//         break;
//     case 3:
//         Console.WriteLine("Среда");
//         break;
//     case 4:
//         Console.WriteLine("Четверг");
//         break;
//     case 5:
//         Console.WriteLine("Пятница");
//         break;
//     case 6:
//         Console.WriteLine("Субота");
//         break;
//     case 7:
//         Console.WriteLine("Воскресенье");
//         break;

//     default:
//         Console.WriteLine("Такого дня не существует");
//         break;
// }