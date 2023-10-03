/* Задача 25: Напишите цикл, 
который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

using System.Reflection;
using System.Runtime.Versioning;

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Degree(int A, int B)
{
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res *= A;
    }
    return res;
}

int userNumberA = GetUserInput("Введите число А: ");
int userNumberB = GetUserInput("Введите число B: ");

int result = Degree(userNumberA, userNumberB);

Console.WriteLine($"{userNumberA}, {userNumberB} -> {result}");