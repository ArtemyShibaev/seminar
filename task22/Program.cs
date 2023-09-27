// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

using System.Runtime.Versioning;

void SquareNumbers(int N)
{
    int count = 1;
    while (count <= N)
    {
        Console.WriteLine(count * count);
        count++;
    }
}


Console.WriteLine("Digit input from user:");
int userNum = Convert.ToInt32(Console.ReadLine());
SquareNumbers(userNum);