﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber > 0 ){
    int count = 2;
    while (count <= userNumber)
    {
        
        Console.Write($"{count} ");
        count = count + 2;
    }
}else {
    Console.WriteLine("Ошибка ввода!");
}