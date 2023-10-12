/* Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


// using System.Runtime.Intrinsics.X86;
// using Internal;

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double IntersectionPoint(int b1, int k1, int b2, int k2)
{
    return (b2 - b1) / (k1 - k2);

}


int b1_U = GetUserInput("Введите b1: ");
int k1_U = GetUserInput("Введите k1: ");
int b2_U = GetUserInput("Введите b2: ");
int k2_U = GetUserInput("Введите k2: ");

double x_U = IntersectionPoint(b1_U, k1_U, b2_U, k2_U);

Console.WriteLine(x_U);