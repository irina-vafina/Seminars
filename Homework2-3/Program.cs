// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

void Weekend()
{
    int day;

    Console.Write ("Введите число для недели (от 1 до 7):  ");
    day = Convert.ToInt32(Console.ReadLine());

    if (day == 7) Console.WriteLine ("Выходной день");
    if (day == 1||day == 2||day == 3||day == 4||day == 5||day == 6) Console.WriteLine ("Не выходной день");
    if (day > 7||day < 1) Console.WriteLine ("Ошибка. Введите число от 1 до 7");
}

Weekend();





















