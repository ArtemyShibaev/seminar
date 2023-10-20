/* Задача 59: 
Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива. */

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


int[] FindLowValueRowColumn(int[,] matrix)
{
    int rowNum = 0;
    int columnNum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rowNum, columnNum])
            {
                rowNum = i;
                columnNum = j;
            }
        }
    }
    return new int[] { rowNum, columnNum };

}


int[,] MatrixDeletRowCol(int[,] matrix, int rowToDel, int colToDel)
{
    int[,] resMatrix = new int[matrix.GetLength(0) -1, matrix.GetLength(1) -1];
    int row = 0;
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        if (i == rowToDel) row++;
        int col = 0;
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            if (j == colToDel) col++;
            resMatrix[i, j] = matrix[row,col];
            col++;
        }
        row++;
    }
    return resMatrix;
}


int[,] rndMatrix = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(rndMatrix);
int[] rndArray = FindLowValueRowColumn(rndMatrix);
Console.WriteLine($" row {rndArray[0]} col {rndArray[1]} min val = {rndMatrix[rndArray[0], rndArray[1]]}");

int[,] resMatrx = MatrixDeletRowCol(rndMatrix, rndArray[0], rndArray[1]);
PrintMatrix(resMatrx);