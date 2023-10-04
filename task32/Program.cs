/* Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */


//using System;

int[] CreateArrayRndInt(int size, int min, int max)               // Создание одномерного массива с рандомными числами
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}


void PrintArray(int[] arr)                                       // Вывод массива в нужном виде
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


void SignInversion(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = - numbers[i];
    }
}


int[] randArray = CreateArrayRndInt(5, -10, 11);
PrintArray(randArray);
SignInversion(randArray);
PrintArray(randArray);