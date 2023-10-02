/* Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */


using System.Diagnostics.CodeAnalysis;
using Internal;

int[] RandomArray(int arrLength)
{
    int[] arr = new int[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = new Random().Next(2);
    }
    return arr;
}

void PrintArray(int[] array)
{
    string output = "[";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}," : $"{array[i]}]";

    }
    Console.WriteLine(output);
}

int[] arr = RandomArray(8);
PrintArray(arr);