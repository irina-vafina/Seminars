﻿int day;

Console.Write ("Введите число для недели (от 1 до 7):  ");
day = Convert.ToInt32(Console.ReadLine());

if (day == 1 )
{
    Console.WriteLine ("Понедельник");
}
if (day == 2 )
{
    Console.WriteLine ("Вторник");
}
if (day == 3 )
{
    Console.WriteLine ("Среда");
}
if (day == 4 )
{
    Console.WriteLine ("Четверг");
}
if (day == 5 )
{
    Console.WriteLine ("Пятница");
}
if (day == 6 )
{
    Console.WriteLine ("Суббота");
}
if (day == 7 )
{
    Console.WriteLine ("Воскресенье");
}
if (day > 7 )
{
    Console.WriteLine ("Ошибка. Введите число от 1 до 7");
}
