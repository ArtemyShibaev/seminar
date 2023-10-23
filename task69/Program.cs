/* Задача 69: 
Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.WriteLine("Введите натуральное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число: ");
int numberB = Convert.ToInt32(Console.ReadLine());


int RaisingAtoPowerB(int a, int b)
{
    if (b == 0) return 1;
    return a * RaisingAtoPowerB(a, b - 1);
}


Console.WriteLine($" A = {numberA}; B = {numberB} -> {RaisingAtoPowerB(numberA, numberB)}");