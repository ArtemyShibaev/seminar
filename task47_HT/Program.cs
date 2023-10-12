/* Задача 47: 
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */


double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)               // Создание двумерного Вещественного массива с рандомными числами
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }

    return matrix;
}



void PrintMatrix(double[,] matrix)                                                       // Вывод массива в нужном виде
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:F1}\t ");    // ,5 <- расстояние между значениями в массиве
        }
        Console.WriteLine("  ");
    }
    
}


double[,] matrix = CreateMatrixRndDouble(3, 4, -10, 9);
PrintMatrix(matrix);
