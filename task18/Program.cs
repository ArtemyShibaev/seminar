/* Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y). */

using System.Globalization;

string RangeCoordinates(int num)
{

    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}

Console.WriteLine("Введите номер четверти: ");

int quater = Convert.ToInt32(Console.ReadLine());

string range = RangeCoordinates(quater);

Console.WriteLine(range);



