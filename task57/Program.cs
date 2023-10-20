/* Задача 57: 
Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
 */

using System;
//using Internal;

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)               // Создание двумерного массива с рандомными числами
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}


void PrintMatrix(int[,] matrix)                                                       // Вывод массива в нужном виде
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");    // ,5 <- расстояние между значениями в массиве
        }
        Console.WriteLine("  ]");
    }

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



int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
    }
    return array;
}


void DictionaryArray(int[] array)
{
    int count = 1;
    int currentNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNum) count++;
        else 
        {
            Console.WriteLine($"{currentNum} -> {count}");
            currentNum = array[i];
            count = 1;
        }
        
    }
    Console.WriteLine($"{currentNum} -> {count}");
}



int[,] rndMatrix = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(rndMatrix);
Console.WriteLine(" ");
int[] rndArray = MatrixToArray(rndMatrix);
Array.Sort(rndArray);
PrintArray(rndArray);
DictionaryArray(rndArray);