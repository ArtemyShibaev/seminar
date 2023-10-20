/* Задача 53: 
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
 */

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



void SwapMatrixFirstLastRow(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

int[,] rdnMatrix = CreateMatrixRndInt(4, 5 , 0, 10);
PrintMatrix(rdnMatrix);
Console.WriteLine(" ");
SwapMatrixFirstLastRow(rdnMatrix);
PrintMatrix(rdnMatrix);