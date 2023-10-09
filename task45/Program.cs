/* Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. */


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


int[] CopyArray(int[] array)
{
    int size = array.Length;
    int[] copyArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}



int[] randArray = CreateArrayRndInt(5, -10, 11);
PrintArray(randArray);
int[] copyArr = CopyArray(randArray);
PrintArray(copyArr);