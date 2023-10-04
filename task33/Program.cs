/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */



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


bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }

    }
    return false;
}


int[] arr = CreateArrayRndInt(10, 0, 10);
PrintArray(arr);
bool findNumber = FindNumber(arr, 0);

Console.WriteLine(findNumber ? "искомое число найдено" : "искомое число не найдено");