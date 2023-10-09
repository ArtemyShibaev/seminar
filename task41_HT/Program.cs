/* Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

using System.Buffers;

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int[] InputArray(int size)                                         // поэлементный ввод массива от пользователя
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetUserInput($"Enter {i + 1} element ");
    }
    return array;
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


int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int size = GetUserInput("Введите количество элементов");
int[] arr = InputArray(size);
PrintArray(arr);
int posistveElements = CountPositiveNumbers(arr);
Console.WriteLine($" -> {posistveElements} ");