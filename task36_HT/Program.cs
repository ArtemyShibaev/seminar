/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

using System.Diagnostics.CodeAnalysis;
//using Internal;

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
    Console.Write("]");
}


int OddPossitionElem(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (i % 2 != 0) sum += array[i];

    }
    return sum;
}


int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
int result = OddPossitionElem(array);
Console.WriteLine($" -> {result}");