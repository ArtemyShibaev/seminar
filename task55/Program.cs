/* Задача 55: 
Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */

using System.Threading.Tasks.Sources;
//using Internal;
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


void SwapColumnsRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

int[,] rndMatrix = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(rndMatrix);
Console.WriteLine(" ");
if (rndMatrix.GetLength(0) == rndMatrix.GetLength(1))
{
    SwapColumnsRows(rndMatrix);
    PrintMatrix(rndMatrix);
}
else
    Console.WriteLine("Swapping impossible!");