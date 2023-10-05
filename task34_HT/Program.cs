/* Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


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


int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}



int[] array = CreateArrayRndInt(10, 100, 1000);
PrintArray(array);
int countEvenNumbers = CountEvenNumbers(array);
Console.WriteLine($" -> {countEvenNumbers}");